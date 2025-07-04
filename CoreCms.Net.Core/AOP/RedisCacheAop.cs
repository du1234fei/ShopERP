﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using CoreCms.Net.Caching.AutoMate.RedisCache;
using CoreCms.Net.Core.Attribute;

namespace CoreCms.Net.Core.AOP
{
    /// <summary>
    /// 面向切面的Redis缓存使用
    /// </summary>
    public class RedisCacheAop : CacheAopBase
    {
        //通过注入的方式，把缓存操作接口通过构造函数注入
        private readonly IRedisOperationRepository _cache;
        public RedisCacheAop(IRedisOperationRepository cache)
        {
            _cache = cache;
        }

        //Intercept方法是拦截的关键所在，也是IInterceptor接口中的唯一定义
        public override void Intercept(IInvocation invocation)
        {
            var method = invocation.MethodInvocationTarget ?? invocation.Method;
            if (method.ReturnType == typeof(void) || method.ReturnType == typeof(Task))
            {
                invocation.Proceed();
                return;
            }
            //对当前方法的特性验证
            if (method.GetCustomAttributes(true).FirstOrDefault(x => x.GetType() == typeof(CachingAttribute)) is CachingAttribute qCachingAttribute)
            {
                //获取自定义缓存键
                var cacheKey = CustomCacheKey(invocation);
                //注意是 string 类型，方法GetValue
                var cacheValue = _cache.Get(cacheKey).Result;
                if (cacheValue != null)
                {
                    //将当前获取到的缓存值，赋值给当前执行方法
                    var returnType = typeof(Task).IsAssignableFrom(method.ReturnType) ? method.ReturnType.GenericTypeArguments.FirstOrDefault() : method.ReturnType;

                    dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(cacheValue, returnType);
                    invocation.ReturnValue = (typeof(Task).IsAssignableFrom(method.ReturnType)) ? Task.FromResult(result) : result;
                    return;
                }
                //去执行当前的方法
                invocation.Proceed();

                //存入缓存
                if (!string.IsNullOrWhiteSpace(cacheKey))
                {
                    object response;

                    //Type type = invocation.ReturnValue?.GetType();
                    var type = invocation.Method.ReturnType;
                    if (typeof(Task).IsAssignableFrom(type))
                    {
                        var resultProperty = type.GetProperty("Result");
                        response = resultProperty.GetValue(invocation.ReturnValue);
                    }
                    else
                    {
                        response = invocation.ReturnValue;
                    }
                    response ??= string.Empty;

                    _cache.Set(cacheKey, response, TimeSpan.FromMinutes(qCachingAttribute.AbsoluteExpiration)).Wait();
                }
            }
            else
            {
                invocation.Proceed();//直接执行被拦截方法
            }
        }

    }
}

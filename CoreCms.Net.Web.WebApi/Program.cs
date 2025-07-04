using System;
using System.Linq;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using CoreCms.Net.Auth;
using CoreCms.Net.Configuration;
using CoreCms.Net.Core.AutoFac;
using CoreCms.Net.Core.Config;
using CoreCms.Net.Filter;
using CoreCms.Net.Loging;
using CoreCms.Net.Mapping;
using CoreCms.Net.Middlewares;
using CoreCms.Net.Swagger;
using CoreCms.Net.Task;
using CoreCms.Net.Web.WebApi.Infrastructure;
using CoreCms.Net.WeChat.Service.Mediator;
using Essensoft.Paylink.Alipay;
using Essensoft.Paylink.WeChatPay;
using Hangfire;
using Hangfire.Dashboard.BasicAuthorization;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NLog.Web;

namespace CoreCms.Net.Web.WebApi
{
    /// <summary>
    /// 开始启动
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 程序的入口
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.AddServicesToContainer();

            //AutoFac注册
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

            //使用 AutoFac 替换 .NET Core 现有的 容器
            builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
            {
                //获取所有控制器类型并使用属性注入
                var controllerBaseType = typeof(ControllerBase);

                containerBuilder.RegisterAssemblyTypes(typeof(Program).Assembly)
                    .Where(t => controllerBaseType.IsAssignableFrom(t) && t != controllerBaseType)
                    .PropertiesAutowired();

                containerBuilder.RegisterModule(new AutofacModuleRegister());
            });

            var app = builder.Build();

            app.ConfigureRequestPipeline();

            try
            {
                //确保NLog.config中连接字符串与appsettings.json中同步
                NLogUtil.EnsureNlogConfig("NLog.config");

                //其他项目启动时需要做的事情
                NLogUtil.WriteLogFile(NLog.LogLevel.Trace, LogType.ApiRequest, "接口启动", "接口启动成功");

                app.Run();
            }
            catch (Exception ex)
            {
                //使用Nlog写到本地日志文件（万一数据库没创建/连接成功）
                NLogUtil.WriteFileLog(NLog.LogLevel.Error, LogType.ApiRequest, "接口启动", "初始化数据异常", ex);
                throw;
            }

        }
    }
}
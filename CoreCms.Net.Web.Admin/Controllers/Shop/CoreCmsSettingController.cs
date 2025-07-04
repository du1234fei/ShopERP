
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CoreCms.Net.Configuration;
using CoreCms.Net.Filter;
using CoreCms.Net.IServices;
using CoreCms.Net.Loging;
using CoreCms.Net.Model.FromBody;
using CoreCms.Net.Model.ViewModels.UI;
using CoreCms.Net.Utility.Helper;
using CoreCms.Net.Web.Admin.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NPOI.HSSF.UserModel;
using SqlSugar;

namespace CoreCms.Net.Web.Admin.Controllers
{
    /// <summary>
    /// 平台设置表
    ///</summary>
    [Description("平台设置表")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    [RequiredErrorForAdmin]
    [Authorize(Permissions.Name)]
    public class CoreCmsSettingController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ICoreCmsSettingServices _coreCmsSettingServices;

        /// <summary>
        /// 构造函数
        ///</summary>
        ///  <param name="webHostEnvironment"></param>
        ///<param name="CoreCmsSettingServices"></param>
        public CoreCmsSettingController(IWebHostEnvironment webHostEnvironment, ICoreCmsSettingServices CoreCmsSettingServices)
        {
            _webHostEnvironment = webHostEnvironment;
            _coreCmsSettingServices = CoreCmsSettingServices;
        }

        #region 首页数据============================================================
        // POST: Api/CoreCmsSetting/GetIndex
        /// <summary>
        /// 首页数据
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Description("首页数据")]
        public async Task<AdminUiCallBack> GetIndex()
        {
            //返回数据
            var jm = new AdminUiCallBack { code = 0 };
            var configs = await _coreCmsSettingServices.GetConfigDictionaries();
            var filesStorageOptionsType = EnumHelper.EnumToList<GlobalEnumVars.FilesStorageOptionsType>();

            jm.data = new
            {
                configs,
                filesStorageOptionsType
            };

            return jm;
        }
        #endregion

        #region 保存提交============================================================
        // POST: Api/CoreCmsSetting/DoSave
        /// <summary>
        /// 保存提交
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Description("保存提交")]
        public async Task<AdminUiCallBack> DoSave([FromBody] FMCoreCmsSettingDoSaveModel model)
        {
            var jm = await _coreCmsSettingServices.UpdateAsync(model);
            return jm;
        }
        #endregion


    }



}

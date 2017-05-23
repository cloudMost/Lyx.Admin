using Abp.Auditing;
using Lyx.Admin.Common;
using Lyx.Admin.Common.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lyx.Admin.Web.Controllers
{
    public class FileManageController : AdminControllerBase
    {
        private readonly IFileUpload _FileUploadManager;
        private readonly IAppPathSetting _AppPathSetting;

        public FileManageController(IFileUpload fileUpload, IAppPathSetting appPathSetting)
        {
            _FileUploadManager = fileUpload;
            _AppPathSetting = appPathSetting;
        }
        // GET: FileManage
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 批量上传文件
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [DisableAuditing]
        public ActionResult UploadFiles()
        {
            var context = HttpContext;
            _FileUploadManager.Upload(context,_AppPathSetting.FileUploadPath);
            return Content("123");
        }
    }
}
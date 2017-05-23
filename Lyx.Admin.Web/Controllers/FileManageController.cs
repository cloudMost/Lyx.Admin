using Abp.Auditing;
using Lyx.Admin.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lyx.Admin.Web.Controllers
{
    public class FileManageController : AdminControllerBase
    {
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
            //
            var context = HttpContext;


            return Content("123");
        }
    }
}
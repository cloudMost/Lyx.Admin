﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Lyx.Admin.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AdminControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
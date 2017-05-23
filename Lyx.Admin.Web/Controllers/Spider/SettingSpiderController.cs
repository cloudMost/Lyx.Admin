using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lyx.Admin.Web.Controllers
{
    public class SettingSpiderController : Controller
    {
        // GET: SettingSpider
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 获取所有配置信息
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> GetSettings()
        {
            //获取数据集合
            //var novels = await _spiderAppService.GetNovels(input);

            return View();

        }
    }
}
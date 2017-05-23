using Abp.BackgroundJobs;
using Hangfire;
using Lyx.Admin.TaoJin;
using Lyx.Admin.TaoJin.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lyx.Admin.Web.Controllers
{
    /// <summary>
    /// 农贸市场模块
    /// </summary>
    public class TaoJinEarnController : Controller
    {
        private readonly ITaoJinAppService _taoJinAppService;
        public TaoJinEarnController(ITaoJinAppService taoJinAppService)
        {
            _taoJinAppService = taoJinAppService;
        }
        // GET: TaoJinEarn
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<ActionResult> GetFruits(GetFruitInput input)
        {
            //获取数据集合
            var novels = await _taoJinAppService.GetFruits(input);
         
            //获取
            //RecurringJob.AddOrUpdate<ITaoJinAppService>(x =>x.InsertSpiderFruits(),Cron.Minutely());

            return Json(novels.Items);
        }
    }
}
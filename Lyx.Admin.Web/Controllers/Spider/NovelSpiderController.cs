using Lyx.Admin.Spider;
using Lyx.Admin.Spider.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lyx.Admin.Web.Controllers
{
    public class NovelSpiderController : Controller
    {
        private readonly ISpiderAppService _spiderAppService;
        public NovelSpiderController(ISpiderAppService spiderAppService)
        {
            _spiderAppService = spiderAppService;
        }

        // GET: NovelSpider
        public ActionResult Index()
        {


            return View();
        }
        [HttpPost]
        public async Task<ActionResult> GetNovels(GetNovelInput input)
        {
            //获取数据集合
            var novels = await _spiderAppService.GetNovels(input);
            
            return Json(new
            {
                total = novels.TotalCount,
                rows = novels.Items
            });

        }
    }
}
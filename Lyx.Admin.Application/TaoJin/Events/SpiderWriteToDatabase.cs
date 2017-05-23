using Abp.AutoMapper;
using Abp.Dependency;
using Abp.Events.Bus.Handlers;
using Lyx.Admin.Spider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyx.Admin.TaoJin.Events
{
    public class SpiderWriteToDatabase : IEventHandler<SpiderFruitCompletdEventData>, ITransientDependency
    {
        private readonly TaoJinManager _taoJinManager;
        /// <summary>
        /// 注入服务
        /// </summary>
        /// <param name="taojinService"></param>
        public SpiderWriteToDatabase(TaoJinManager taoJinManager)
        {
            _taoJinManager = taoJinManager;
        }
        /// <summary>
        /// 事件处理
        /// </summary>
        /// <param name="eventData"></param>
        public void HandleEvent(SpiderFruitCompletdEventData eventData)
        {
            var list = eventData.Data.MapTo<List<InterFruit>>();
            //将更新数据库任务加入队列进行更新
            _taoJinManager.InsertInterFruits(list);

        }
        
    }
}

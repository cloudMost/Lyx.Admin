using Abp.Events.Bus;
using Lyx.Admin.TaoJin.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyx.Admin.TaoJin.Events
{
    /// <summary>
    /// 用于更新淘金农场信息
    /// </summary>
    public class SpiderFruitCompletdEventData:EventData
    {
        private List<SpiderFruitListDto> _Data;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        public SpiderFruitCompletdEventData(List<SpiderFruitListDto> Data)
        {
            this._Data = Data;
        }

        public List<SpiderFruitListDto> Data
        {
            get
            {
                return _Data;
            }
        }
    }
}

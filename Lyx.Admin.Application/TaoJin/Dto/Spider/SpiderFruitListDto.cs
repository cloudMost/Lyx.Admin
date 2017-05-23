using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Lyx.Admin.Spider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyx.Admin.TaoJin.Dto
{
    [AutoMap(typeof(InterFruit))]
    /// <summary>
    /// 爬取淘金农场交易数据
    /// </summary>
    public class SpiderFruitListDto:EntityDto<int>
    {
        /// <summary>
        /// 水果名
        /// </summary>
        public String ProductName { get; set; }
        /// <summary>
        /// 水果编码
        /// </summary>
        public String ProductCode { get; set; }
        /// <summary>
        /// 涨幅
        /// </summary>
        public Decimal IncreaseRate { get; set; }
        /// <summary>
        /// 涨跌
        /// </summary>
        public Decimal Increase { get; set; }
        /// <summary>
        /// 今开
        /// </summary>
        public Decimal OpenPrice { get; set; }
        /// <summary>
        /// 最高
        /// </summary>
        public Decimal HighestPrice { get; set; }
        /// <summary>
        /// 最低
        /// </summary>
        public Decimal LowestPrice { get; set; }
        /// <summary>
        /// 当前价格
        /// </summary>
        public Decimal Price { get; set; }
        /// <summary>
        /// 成交量
        /// </summary>
        public Decimal Volume { get; set; }
    }
}

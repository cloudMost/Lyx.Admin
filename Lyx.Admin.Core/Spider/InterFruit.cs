using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyx.Admin.Spider
{
    /// <summary>
    /// 淘金水果类型
    /// </summary>
    [Table("TaoJin_InterFruit")]
    public class InterFruit : CreationAuditedEntity<int>
    {
        /// <summary>
        /// 水果名
        /// </summary>
        public virtual String ProductName { get; set; }
        /// <summary>
        /// 水果编码
        /// </summary>
        public virtual String ProductCode { get; set; }
        /// <summary>
        /// 涨幅
        /// </summary>
        public virtual Decimal IncreaseRate { get; set; }
        /// <summary>
        /// 涨跌
        /// </summary>
        public virtual Decimal Increase { get; set; }
        /// <summary>
        /// 今开
        /// </summary>
        public virtual Decimal OpenPrice { get; set; }
        /// <summary>
        /// 最高
        /// </summary>
        public virtual Decimal HighestPrice { get; set; }
        /// <summary>
        /// 最低
        /// </summary>
        public virtual Decimal LowestPrice { get; set; }
        /// <summary>
        /// 当前价格
        /// </summary>
        public virtual Decimal Price { get; set; }
        /// <summary>
        /// 成交量
        /// </summary>
        public virtual Decimal Volume { get; set; }
       


    }
}

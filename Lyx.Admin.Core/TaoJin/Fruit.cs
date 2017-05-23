using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyx.Admin.TaoJin
{
    /// <summary>
    /// 淘金水果类型
    /// </summary>
    [Table("TaoJin_Fruit")]
    public class Fruit : CreationAuditedEntity<int>
    {
        /// <summary>
        /// 水果名
        /// </summary>
        public virtual String FruitName { get; set; }
        /// <summary>
        /// 水果编码
        /// </summary>
        public virtual String FruitCode { get; set; }
        /// <summary>
        /// 图片路径
        /// </summary>
        public virtual String ImageUrl { get; set; }
        /// <summary>
        /// 当前价格
        /// </summary>
        public virtual Decimal CurrPrice { get; set; }
        /// <summary>
        /// 成交量
        /// </summary>
        public virtual Decimal Volume { get; set; }
        /// <summary>
        /// 序列
        /// </summary>
        public virtual int Order { get; set; }


    }
}

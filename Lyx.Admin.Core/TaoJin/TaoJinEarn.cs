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
    /// 种植情况实体
    /// </summary>
    [Table("TaoJin_Earn")]
    public class TaoJinEarn : CreationAuditedEntity<int>
    {
        /// <summary>
        /// 记录时间
        /// </summary>
        public virtual DateTime? RecordDate { get; set; }
        /// <summary>
        /// 消耗种子
        /// </summary>
        public virtual int ConsumeSeed{get;set;}

    }
}

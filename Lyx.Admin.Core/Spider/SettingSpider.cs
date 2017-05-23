using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lyx.Admin.Spider
{
    /// <summary>
    /// 爬虫配置信息
    /// </summary>
    [Table("Spider_Setting")]
    public class SettingSpider : CreationAuditedEntity<int>
    {
        /// <summary>
        /// 编号
        /// </summary>
        public virtual String Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public virtual String Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public virtual String Description{ get; set; }
        /// <summary>
        /// 时间间隔
        /// </summary>
        public virtual int Duration { get; set; }
        /// <summary>
        /// 是否开启
        /// </summary>
        public virtual bool IsOpen { get; set; }


    }
}

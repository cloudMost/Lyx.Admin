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
    /// 文章类
    /// </summary>
    [Table("Spider_Article")]
    public class ArticleSpider: CreationAuditedEntity<int>
    {
        /// <summary>
        /// 小说标题
        /// </summary>
        public virtual string Title { get; set; }
        /// <summary>
        /// 小说内容
        /// </summary>
        public virtual string Content { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual NovelSpider Novel { get; set; }
    }
}

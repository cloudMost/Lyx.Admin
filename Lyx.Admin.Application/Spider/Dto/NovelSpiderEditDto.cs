using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;
using Abp.Runtime.Validation;
using Abp.AutoMapper;

namespace Lyx.Admin.Spider.Dto
{
    [AutoMap(typeof(NovelSpider))]
    public class NovelSpiderEditDto
    {
        public long? Id { get; set; }

        [Required]
        [StringLength(NovelSpider.MaxNovelNameLength)]
        public string Name { get; set; }
        
    }
}
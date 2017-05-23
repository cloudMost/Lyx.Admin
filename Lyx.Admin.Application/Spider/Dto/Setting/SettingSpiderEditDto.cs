using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;
using Abp.Runtime.Validation;
using Abp.AutoMapper;

namespace Lyx.Admin.Spider.Dto
{
    [AutoMap(typeof(SettingSpider))]
    public class SettingSpiderEditDto
    {
        public long? Id { get; set; }

        [Required]
        public string Name { get; set; }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace Lyx.Admin.Spider.Dto
{
    public class CreateOrUpdateSettingInput
    {
        [Required]
        public SettingSpiderEditDto Setting { get; set; }
        

        
    }
}

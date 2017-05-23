using Lyx.Admin.Spider.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyx.Admin.TaoJin.Dto
{
    public class CreateOrUpdateFruitInput
    {
        [Required]
        public FruitEditDto Fruit { get; set; }
    }
}

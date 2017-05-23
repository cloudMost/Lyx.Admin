using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyx.Admin.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class PagedListAndSortedInput : ISortedResultRequest
    {
        public string Sorting { get; set; }
    }
}

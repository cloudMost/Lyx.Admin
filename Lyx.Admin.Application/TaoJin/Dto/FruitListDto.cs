using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyx.Admin.TaoJin.Dto
{
    /// <summary>
    /// 列表Dto
    /// </summary>
    [AutoMapFrom(typeof(Fruit))]
    public class FruitListDto: EntityDto<int>
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
        /// 创建时间
        /// </summary>
        public virtual DateTime CreationTime { get; set; }

        /// <summary>
        /// 序列
        /// </summary>
        public virtual int Order { get; set; }

    }
}

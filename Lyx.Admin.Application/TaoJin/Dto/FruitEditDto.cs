using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;
using Abp.Runtime.Validation;
using Abp.AutoMapper;
using Lyx.Admin.TaoJin;
using System;

namespace Lyx.Admin.TaoJin.Dto
{
    [AutoMap(typeof(Fruit))]
    public class FruitEditDto
    {
        public int? Id { get; set; }
        /// <summary>
        /// 水果名
        /// </summary>
        [Required]
        public String FruitName { get; set; }
        /// <summary>
        /// 水果编码
        /// </summary>
        public String FruitCode { get; set; }

        /// <summary>
        /// 图片路径
        /// </summary>
        public String ImageUrl { get; set; }
        /// <summary>
        /// 当前价格
        /// </summary>
        public Decimal CurrPrice { get; set; }
        /// <summary>
        /// 成交量
        /// </summary>
        public Decimal Volume { get; set; }

        /// <summary>
        /// 序列
        /// </summary>
        public int Order { get; set; }

    }
}
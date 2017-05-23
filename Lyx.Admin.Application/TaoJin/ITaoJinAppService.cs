using System.Threading.Tasks;
using Abp.Application.Services;
using Lyx.Admin.TaoJin.Dto;
using Abp.Application.Services.Dto;

namespace Lyx.Admin.TaoJin
{
    public interface ITaoJinAppService : IApplicationService
    {
        /// <summary>
        /// 获取水果集合
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ListResultDto<FruitListDto>> GetFruits(GetFruitInput input);

        /// <summary>
        /// 创建或更新水果
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdateFruit(CreateOrUpdateFruitInput input);
        /// <summary>
        /// 删除水果信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task DeleteFruit(EntityDto<int> input);
        /// <summary>
        /// 通过id获取水果信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<Fruit> GetFruitById(EntityDto<int> input);


        Task<ListResultDto<SpiderFruitListDto>> GetSpiderFruits();

        Task InsertSpiderFruits();
    }
}

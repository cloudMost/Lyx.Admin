using System.Linq;
using System.Linq.Dynamic;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.Entity;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;

using Lyx.Admin.TaoJin.Dto;
using Abp.AutoMapper;
using System;
using System.Net.Http;
using Abp.Json;
using Newtonsoft.Json;
using Abp.Events.Bus;
using Lyx.Admin.TaoJin.Events;

namespace Lyx.Admin.TaoJin
{
    /// <summary>
    /// 爬虫服务
    /// </summary>
    public class TaoJinAppService : AdminAppServiceBase, ITaoJinAppService
    {
        private readonly IRepository<Fruit> _taoJinRepository;

        private readonly TaoJinManager _taoJinManager;
        public IEventBus EventBus { get; set; }
        /// <summary>
        /// 构造
        /// </summary>
        public TaoJinAppService(IRepository<Fruit> taoJinRepository, TaoJinManager taoJinManager)
        {
            _taoJinRepository = taoJinRepository;
            _taoJinManager = taoJinManager;
            EventBus = NullEventBus.Instance;
        }
        /// <summary>
        /// 获取水果列表数据(非分页)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ListResultDto<FruitListDto>> GetFruits(GetFruitInput input)
        {
            var query= _taoJinRepository.GetAll();
            
            //增加查询条件
            //query=query.WhereIf(!input.);

            var resultCount = await query.CountAsync();
            var results = await query
                .AsNoTracking()
                .OrderBy(input.Sorting)
                .ToListAsync();


            return new ListResultDto<FruitListDto>(results.MapTo<List<FruitListDto>>());
        }
        /// <summary>
        /// 创建或更新水果
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task CreateOrUpdateFruit(CreateOrUpdateFruitInput input)
        {
            if (input.Fruit.Id.HasValue)
            {
                await UpdateFruitAsync(input);
            }
            else
            {
                await CreateFruitAsync(input);
            }
        }

        
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        protected virtual async Task CreateFruitAsync(CreateOrUpdateFruitInput input)
        {
            try
            {
                var fruit = input.Fruit.MapTo<Fruit>();
                await _taoJinManager.CreateFruitTypeAsync(fruit);
            }
            catch (System.Exception ex)
            {

                throw;
            }

        }

        protected virtual async Task UpdateFruitAsync(CreateOrUpdateFruitInput input)
        {
            try
            {
                var fruit = await _taoJinManager.GetFruitById(input.Fruit.Id);
                if (!string.IsNullOrEmpty(input.Fruit.FruitName))
                {
                    fruit.FruitName = input.Fruit.FruitName;
                }

                fruit.Order = input.Fruit.Order;
                if (!string.IsNullOrEmpty(input.Fruit.FruitCode))
                {
                    fruit.FruitCode = input.Fruit.FruitCode;
                }
                await _taoJinManager.UpdateFruitTypeAsync(fruit);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
        /// <summary>
        /// 删除水果
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public virtual async Task DeleteFruit(EntityDto<int> input)
        {

            var fruit = await _taoJinManager.GetFruitById(input.Id);

            await _taoJinManager.DeleteFruitAsync(fruit);
        }
        /// <summary>
        /// 通过id获取水果
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public virtual async Task<Fruit> GetFruitById(EntityDto<int> input)
        {
            var fruit=await _taoJinManager.GetFruitById(input.Id);

            return fruit.MapTo<Fruit>();
        }

        /// <summary>
        /// 获取淘金农场交易数据
        /// </summary>
        /// <returns></returns>
        public virtual async Task<ListResultDto<SpiderFruitListDto>> GetSpiderFruits()
        {
            string post_url = "http://www.taojingy.com/Market/FlushMarket";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36");
                var content = new FormUrlEncodedContent(new Dictionary<string, string>());
                var response = await client.PostAsync(post_url, content);
                String result = response.Content.ReadAsStringAsync().Result;
                if (string.IsNullOrEmpty(result))
                {
                    return null;
                }
               

                return new ListResultDto<SpiderFruitListDto>(JsonConvert.DeserializeObject<SpiderFruitInput>(result).data);
            }
        }
        /// <summary>
        /// 插入实时价格信息
        /// </summary>
        public virtual async Task InsertSpiderFruits()
        {
            string post_url = "http://www.taojingy.com/Market/FlushMarket";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36");
                var content = new FormUrlEncodedContent(new Dictionary<string, string>());
                var response = await client.PostAsync(post_url, content);
                String result = response.Content.ReadAsStringAsync().Result;
                if (string.IsNullOrEmpty(result))
                {
                    return;
                }

                //触发更新
                EventBus.Trigger(new SpiderFruitCompletdEventData(JsonConvert.DeserializeObject<SpiderFruitInput>(result).data));
              
            }
        }
    }
}

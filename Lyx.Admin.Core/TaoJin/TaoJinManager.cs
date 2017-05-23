using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Lyx.Admin.Spider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyx.Admin.TaoJin
{
    public class TaoJinManager:DomainService
    {
        private readonly IRepository<Fruit> _fruitRepository;
        private readonly IRepository<InterFruit> _interFruitRepository;

        public TaoJinManager(IRepository<Fruit> fruitRepository,IRepository<InterFruit> interFruitRepository)
        {
            _fruitRepository = fruitRepository;
            _interFruitRepository = interFruitRepository;
        }
        /// <summary>
        /// 创建水果
        /// </summary>
        /// <returns></returns>
        public virtual async Task CreateFruitTypeAsync(Fruit fruitType)
        {
            await _fruitRepository.InsertAsync(fruitType);
        }
        public virtual async Task UpdateFruitTypeAsync(Fruit fruitType)
        {
            await _fruitRepository.UpdateAsync(fruitType);
        }

        public virtual async Task<Fruit> GetFruitById(int? id)
        {
            return await _fruitRepository.GetAsync(id.Value);
        }
        /// <summary>
        /// 删除水果
        /// </summary>
        /// <param name="fruit"></param>
        /// <returns></returns>
        public virtual async Task DeleteFruitAsync(Fruit fruit)
        {
            await _fruitRepository.DeleteAsync(fruit);
        }

        /// <summary>
        /// 插入果园实时数据
        /// </summary>
        /// <returns></returns>
        public virtual void InsertInterFruits(IList<InterFruit> entities)
        {
            if (entities!=null&&entities.Count>0)
            {
                foreach (var entity in entities)
                {
                    _interFruitRepository.InsertAsync(entity);
                }
            }
        }
    }
}

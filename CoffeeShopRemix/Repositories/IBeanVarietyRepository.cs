using CoffeeShopRemix.Models;
using System.Collections.Generic;

namespace CoffeeShopRemix.Repositories
{
    public interface IBeanVarietyRepository
    {
        void Add(BeanVariety variety);
        void Delete(int id);
        BeanVariety Get(int id);
        List<BeanVariety> GetAll();
        void Update(BeanVariety variety);
    }
}
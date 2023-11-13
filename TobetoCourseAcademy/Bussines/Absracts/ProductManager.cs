using DataAccess.Concretes;
using Entities.Concretes;

namespace Bussines.Absracts
{
    internal class ProductManager
    {
        public void Add(Category category)
        {
            AdoNetCategoryDal categoryDal = new AdoNetCategoryDal();

            categoryDal.Add(category);
        }
    }
}

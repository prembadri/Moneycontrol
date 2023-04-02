using Moneycontrol.Common.Models;
using Moneycontrol.DAL.Contracts;

namespace Moneycontrol.DAL.Repositories
{
    public class CategoryTypesRepository : ICategoryTypesRepository
    {
        private readonly ISQLiteOperator _sqliteOperator;

        public CategoryTypesRepository(ISQLiteOperator sQLiteOperator)
        {
            _sqliteOperator = sQLiteOperator;
        }

        public List<CategoryTypesModel> GetCategoryTypes()
        {
            return _sqliteOperator.GetCategoryTypes();
        }
    }
}

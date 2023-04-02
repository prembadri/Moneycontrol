using Moneycontrol.BAL.Contracts;
using Moneycontrol.Common.Models;
using Moneycontrol.DAL.Contracts;

namespace Moneycontrol.BAL.Services
{
    public class CategoryTypesService : ICategoryTypesService
    {
        private readonly ICategoryTypesRepository _categoryTypesRepository;

        public CategoryTypesService(ICategoryTypesRepository categoryTypesRepository)
        {
            _categoryTypesRepository = categoryTypesRepository;
        }

        public List<CategoryTypesModel> GetCategoryTypes()
        {
            return _categoryTypesRepository.GetCategoryTypes();
        }
    }
}

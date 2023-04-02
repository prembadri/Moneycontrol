using Moneycontrol.Common.Models;

namespace Moneycontrol.DAL.Contracts
{
    public interface ICategoryTypesRepository
    {
        List<CategoryTypesModel> GetCategoryTypes();
    }
}

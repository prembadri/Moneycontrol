using Moneycontrol.Common.Models;

namespace Moneycontrol.DAL.Contracts
{
    public interface ISQLiteOperator
    {
        List<CategoryTypesModel> GetCategoryTypes();
    }
}

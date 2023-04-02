using Moneycontrol.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneycontrol.BAL.Contracts
{
    public interface ICategoryTypesService
    {
        List<CategoryTypesModel> GetCategoryTypes();
    }
}

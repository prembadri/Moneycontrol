using Microsoft.AspNetCore.Mvc;
using Moneycontrol.BAL.Contracts;
using Moneycontrol.Common.Models;

namespace Moneycontrol.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryTypesController : ControllerBase
    {
        private readonly ICategoryTypesService _categoryTypesService;
        public CategoryTypesController(ICategoryTypesService  categoryTypesService)
        {
            _categoryTypesService = categoryTypesService;
        }

        [HttpGet(Name = "GetCategoryTypes")]
        public IEnumerable<CategoryTypesModel> Get()
        {
            return _categoryTypesService.GetCategoryTypes();
        }
    }
}
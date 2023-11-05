using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<CategoryDto> GetCategories()
        {
            return new List<CategoryDto>()
            {
                new CategoryDto { Id = 1, Name = "TV"  },
                new CategoryDto { Id = 2, Name = "Laptop" },
                new CategoryDto { Id = 3, Name = "Mobile"}
            };
        }
    }
}

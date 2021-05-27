using api.Models;
using Flowaccount.Data.Models;
using Flowaccount.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace api.Controllers
{
    [Produces(MediaTypeNames.Application.Json)]
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryLogic _categoryLogic;

        private static readonly CategoryType[] TransactionTypes = new[]
        { CategoryType.Income, CategoryType.Expense };

        public CategoryController(ILogger<CategoryController> logger, ICategoryLogic categoryLogic)
        {
            _logger = logger;
            _categoryLogic = categoryLogic;
        }

        [HttpGet]
        public GridResponse<Category> Get()
        {
            var result = _categoryLogic.FindBy();
            return result;
        }

        [HttpPost]
        public Category Create(Category model)
        {
            var result = _categoryLogic.Create(model);
            return result;
        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            var result = _categoryLogic.Remove(id);
            return result;
        }

        [HttpPut("{id}")]
        public Category Update(int id, Category model)
        {
            var result = _categoryLogic.Update(id, model);
            return result;
        }
    }
}

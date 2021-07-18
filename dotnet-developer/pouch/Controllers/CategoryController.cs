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

namespace api.Controllers
{
    [Produces(MediaTypeNames.Application.Json)]
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryLogic _CategoryLogic;

        public CategoryController(ILogger<CategoryController> logger, ICategoryLogic CategoryLogic)
        {
            _logger = logger;
            _CategoryLogic = CategoryLogic;
        }

        [HttpGet]
        public GridResponse<Category> Get()
        {
            var result = _CategoryLogic.FindBy();
            return result;
        }

        [HttpPost]
        public Category Create(Category model)
        {
            var result = _CategoryLogic.Create(model);
            return result;
        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            var result = _CategoryLogic.Remove(id);
            return result;
        }

        [HttpPut("{id}")]
        public Category Update(int id, Category model)
        {
            var result = _CategoryLogic.Update(id, model);
            return result;
        }
    }
}

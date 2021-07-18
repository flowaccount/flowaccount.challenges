using api.Models;
using Flowaccount.Data;
using Flowaccount.Data.Handlers;
using Flowaccount.Data.Models;
using Microsoft.Extensions.Logging;
using PagedList;
using System;
using System.Linq;

namespace Flowaccount.Logic
{
    public class CategoryLogic : ICategoryLogic
    {
        private readonly ILogger<CategoryLogic> _logger;
        private readonly IRepository<Category> _CategoryRepository;

        public CategoryLogic(ILogger<CategoryLogic> logger, IRepository<Category> CategoryRepository)
        {
            _logger = logger;
            _CategoryRepository = CategoryRepository;
        }

        public Category Create(Category model)
        {
            var currentDateTime = DateTime.Now;
            model.CreatedOn = currentDateTime;
            model.ModifiedOn = currentDateTime;
            var rowEffected = _CategoryRepository.Save(ActionModes.Create, model);
            if (rowEffected == 0)
            {
                return null;
            }
            return model;
        }

        public GridResponse<Category> FindBy()
        {
            var allValue = _CategoryRepository.Get(m => !m.IsDelete).ToList();
            return new GridResponse<Category>
            {
                Total = allValue.Count(),
                List = allValue.ToPagedList(1, 20)
            };
        }

        public int Remove(int id)
        {
            var currentDateTime = DateTime.Now;
            var existValue = _CategoryRepository.Get(m => m.Id == id && !m.IsDelete).FirstOrDefault();
            if (existValue == null)
            {
                return -1;
            }

            existValue.Id = id;
            existValue.ModifiedOn = currentDateTime;
            var rowEffected = _CategoryRepository.Save(ActionModes.Update, existValue);
            if (rowEffected == 0)
            {
                return -1;
            }
            return 1;
        }

        public Category Update(int id, Category model)
        {
            var currentDateTime = DateTime.Now;
            var existValue = _CategoryRepository.Get(m => m.Id == id && !m.IsDelete).FirstOrDefault();
            if (existValue == null)
            {
                return null;
            }

            model.Id = id;
            model.ModifiedOn = currentDateTime;
            var rowEffected = _CategoryRepository.Save(ActionModes.Update, model);
            if (rowEffected == 0)
            {
                return null;
            }
            return model;
        }
    }
}
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
        private readonly IRepository<Category> _categoryRepository;

        public CategoryLogic(ILogger<CategoryLogic> logger, IRepository<Category> categoryRepository)
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
        }

        public Category Create(Category model)
        {
            var currentDateTime = DateTime.Now;
            model.CreatedOn = currentDateTime;
            model.ModifiedOn = currentDateTime;
            var rowEffected = _categoryRepository.Save(ActionModes.Create, model);
            if(rowEffected == 0)
            {
                throw null;
            }
            return model;
        }

        public GridResponse<Category> FindBy()
        {
            var allValue = _categoryRepository.Get(m => !m.IsDelete).ToList();
            return new GridResponse<Category>
            {
                Total = allValue.Count(),
                List = allValue.ToPagedList(1, 20)
            };
        }

        public int Remove(int id)
        {
            var currentDateTime = DateTime.Now;
            var existValue = _categoryRepository.Get(m => m.Id == id && !m.IsDelete, m => m.Transactions).FirstOrDefault();
            if (existValue == null || existValue.Transactions.Count > 0)
            {
                return -1;
            }

            existValue.Id = id;
            existValue.ModifiedOn = currentDateTime;
            existValue.IsDelete = true;
            var rowEffected = _categoryRepository.Save(ActionModes.Update, existValue);
            if (rowEffected == 0)
            {
                return -1;
            }
            return 1;
        }

        public Category Update(int id, Category model)
        {
            var currentDateTime = DateTime.Now;
            var existValue = _categoryRepository.Get(m => m.Id == id && !m.IsDelete, m => m.Transactions).FirstOrDefault();
            if (existValue == null || (existValue.Transactions.Count > 0 && model.Type != existValue.Type))
            {
                return null;
            }
            
            model.Id = id;
            model.ModifiedOn = currentDateTime;
            var rowEffected = _categoryRepository.Save(ActionModes.Update, model);
            if (rowEffected == 0)
            {
                return null;
            }
            return model;
        }
    }
}
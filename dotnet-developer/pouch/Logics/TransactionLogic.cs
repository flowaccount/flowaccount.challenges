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
    public class TransactionLogic : ITransactionLogic
    {
        private readonly ILogger<TransactionLogic> _logger;
        private readonly IRepository<Transactions> _transactionRepository;

        public TransactionLogic(ILogger<TransactionLogic> logger, IRepository<Transactions> transactionRepository)
        {
            _logger = logger;
            _transactionRepository = transactionRepository;
        }

        public Transactions Create(Transactions model)
        {
            var currentDateTime = DateTime.Now;
            model.CreatedOn = currentDateTime;
            model.ModifiedOn = currentDateTime;
            var rowEffected = _transactionRepository.Save(ActionModes.Create, model);
            if(rowEffected == 0)
            {
                return null;
            }
            return model;
        }

        public GridResponse<Transactions> FindBy()
        {
            var allValue = _transactionRepository.Get(m => !m.IsDelete, m => m.Category).ToList();
            return new GridResponse<Transactions>
            {
                Total = allValue.Count(),
                List = allValue.ToPagedList(1, 20)
            };
        }

        public int Remove(long id)
        {
            var currentDateTime = DateTime.Now;
            var existValue = _transactionRepository.Get(m => m.Id == id && !m.IsDelete).FirstOrDefault();
            if (existValue == null)
            {
                return -1;
            }

            existValue.Id = id;
            existValue.ModifiedOn = currentDateTime;
            var rowEffected = _transactionRepository.Save(ActionModes.Update, existValue);
            if (rowEffected == 0)
            {
                return -1;
            }
            return 1;
        }

        public Transactions Update(long id, Transactions model)
        {
            var currentDateTime = DateTime.Now;
            var existValue = _transactionRepository.Get(m => m.Id == id && !m.IsDelete).FirstOrDefault();
            if (existValue == null)
            {
                return null;
            }
            
            model.Id = id;
            model.ModifiedOn = currentDateTime;
            var rowEffected = _transactionRepository.Save(ActionModes.Update, model);
            if (rowEffected == 0)
            {
                return null;
            }
            return model;
        }
    }
}
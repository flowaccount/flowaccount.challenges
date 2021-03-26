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
    public class TransactionController : ControllerBase
    {
        private readonly ILogger<TransactionController> _logger;
        private readonly ITransactionLogic _transactionLogic;
        private static readonly string[] SummariesExpense = new[]
        {
            "กินข้าว", "กินเหล้า", "ซื้อหวย"
        };
        private static readonly string[] SummariesIncome = new[]
        {
            "เงินเดือน", "ถูกหวย", "เก็บเงินได้", "ปันผล"
        };

        private static readonly TransactionType[] TransactionTypes = new[]
        { TransactionType.Income, TransactionType.Expense };

        public TransactionController(ILogger<TransactionController> logger, ITransactionLogic transactionLogic)
        {
            _logger = logger;
            _transactionLogic = transactionLogic;
        }

        [HttpGet]
        public GridResponse<Transactions> Get()
        {
            var result = _transactionLogic.FindBy();
            return result;
        }

        [HttpPost]
        public Transactions Create(Transactions model)
        {
            var result = _transactionLogic.Create(model);
            return result;
        }

        [HttpDelete("{id}")]
        public int Delete(long id)
        {
            var result = _transactionLogic.Remove(id);
            return result;
        }

        [HttpPut("{id}")]
        public Transactions Update(long id, Transactions model)
        {
            var result = _transactionLogic.Update(id, model);
            return result;
        }
    }
}

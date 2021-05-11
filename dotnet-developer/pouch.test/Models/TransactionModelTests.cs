using Flowaccount.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace api.test.Models
{
    public class TransactionModelTests
    { 
        [Fact]
        public void Validate_ValueLessThenZero_ExpectedValidateFailed()
        {
            var model = new Transactions
            { 
                Value = -1
            };
         
            var context = new ValidationContext(model);
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(model, context, results, true);
            Assert.False(isValid);
        }

        [Fact]
        public void Validate_ValueMoreThenZero_ExpectedValidateSuccess()
        {
            var model = new Transactions
            {
                Value = 0
            };

            var context = new ValidationContext(model);
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(model, context, results, true);
            Assert.True(isValid);
        }
    }
}

using System;
using System.Linq;
using api.Models;
using Flowaccount.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace api.ModelBuilderExtensions
{
    internal static class ModelBuilderExtensions
    {
        private static readonly string[] SummariesExpense = new[]
{
            "กินข้าว", "กินเหล้า", "ซื้อหวย"
        };
        private static readonly string[] SummariesIncome = new[]
        {
            "เงินเดือน", "ถูกหวย", "เก็บเงินได้", "ปันผล"
        };

        private static readonly string[] Category = new[]
        {
            "ถูกหวย", "เงินเดือน", "แม่ให้", "ปล้นพี่เสก", "อาหาร"
        };

        private static readonly TransactionType[] TransactionTypes = new[]
        { TransactionType.Income, TransactionType.Expense };

        public static void Seed(this ModelBuilder modelBuilder)
        {
            var rng = new Random();

            //category
            var categoryDate = Category.Select((value, index) =>
            {
                var createOn = DateTime.Now.AddDays(rng.Next(1, 20));
                return new Category
                {
                    Id = index + 1,
                    Name = value,
                    CreatedOn = createOn,
                    ModifiedOn = createOn.AddDays(rng.Next(1, 5))
                };
            }).ToList();
            modelBuilder.Entity<Category>().HasData(categoryDate);



            //transactions
            var transactionData = Enumerable.Range(1, 100).Select(index =>
            {
                var type = TransactionTypes[rng.Next(TransactionTypes.Length)];
                var transactionDate = new DateTime(2019, 1, 1).AddDays(index * -1);

                return new Transactions
                {
                    Id = index,
                    CategoryId = rng.Next(1, categoryDate.Count),
                    TransactionDate = transactionDate,
                    FinancialType = (int)type,
                    Value = rng.Next(1, 80000),
                    Note = type == TransactionType.Expense ? SummariesExpense[rng.Next(SummariesExpense.Length)] : SummariesIncome[rng.Next(SummariesIncome.Length)],
                    CreatedOn = transactionDate,
                    ModifiedOn = transactionDate.AddDays(rng.Next(1, 100))
                };
            });

            modelBuilder.Entity<Transactions>().HasData(transactionData);
        }
    }
}
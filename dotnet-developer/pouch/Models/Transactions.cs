
using api.Models;
using Flowaccount.Data.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Flowaccount.Data.Models
{
    [Table("Transactions")]
    public class Transactions : IEntity
    {
        [Key]
        public long Id { get; set; }
        public int CategoryId { get; set; }
        public DateTime TransactionDate { get; set; }
        [StringLength(1000)]
        public string Note { get; set; }
        public int FinancialType { get; set; }
        [Column(TypeName = "decimal(23,8)")]
        [Range(0, 9999999, ErrorMessage = "Value must be more than 0.")]
        public decimal Value { get; set; }
        [JsonIgnore]
        public bool IsDelete { get; set; }
        [JsonIgnore]
        public int Status { get; set; }
        [JsonIgnore]
        public DateTime CreatedOn { get; set; }
        [JsonIgnore]
        public DateTime ModifiedOn { get; set; }


        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Flowaccount.Data.Handlers;

namespace Flowaccount.Data.Models
{
    [Table("Categories")]
    public class Category : IEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(1000)]
        public string Name { get; set; }
        [JsonIgnore]
        public bool IsDelete { get; set; }
        [JsonIgnore]
        public DateTime CreatedOn { get; set; }
        [JsonIgnore]
        public DateTime ModifiedOn { get; set; }

        [JsonIgnore]
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
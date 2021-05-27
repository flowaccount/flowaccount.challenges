using System;
using Flowaccount.Data.Handlers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Flowaccount.Data.Models;

namespace api.Models
{
    [Table("Categories")]
    public class Category : IEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(1000)]
        public string Name { get; set; }
        [EnumDataType(typeof(CategoryType), ErrorMessage = "Type doesn't exist")]
        public CategoryType Type { get; set; }
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
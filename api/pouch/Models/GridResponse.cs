using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class GridResponse<T>
    {
        public IEnumerable<T> List { get; set; }
        public int CurrentPage { get; set; }
        public int PageNumber { get; set; }
        public int Total { get; set; }
    }
}

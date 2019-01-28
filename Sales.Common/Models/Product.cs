using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Description { get; set; }
        public Decimal price { get; set; } 
        public bool IsAvailable { get; set; }
        public DateTime PublishOn { get; set; }
    }
}

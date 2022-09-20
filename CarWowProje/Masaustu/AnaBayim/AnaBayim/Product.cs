using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaBayim
{
    public class Product
    {
        public int ID { get; set; }

        [Required]
        [StringLength(maximumLength:50)]
        public string ProductName { get; set; }
        public int Category_ID { get; set; }
        [ForeignKey("Category_ID")]
        public virtual Category Category { get; set; }
      
        public int Brand_ID { get; set; }
        [ForeignKey("Brand_ID")]
       
        public virtual Brand Brand { get; set; }
      

        [StringLength(maximumLength:200)]
        public string Description { get; set; }
        public decimal Stock { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
        public string CoverImage { get; set; }
        public DateTime? CreationDay { get; set; }
    }
}

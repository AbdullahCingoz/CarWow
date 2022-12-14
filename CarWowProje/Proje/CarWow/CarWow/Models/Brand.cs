using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarWow.Models
{
    public class Brand
    {
        public int ID { get; set; }
        [Display(Name = "Marka")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [StringLength(maximumLength: 50, ErrorMessage = "Bu alan en fazla 50 karkater olmalıdır")]
        public string Name { get; set; }

        [Display(Name = "Durum")]
        public bool status { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
    
}
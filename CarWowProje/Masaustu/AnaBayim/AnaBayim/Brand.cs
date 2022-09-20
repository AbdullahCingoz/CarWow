using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaBayim
{
    public class Brand
    {
        public int ID { get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        public string BrandName { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Brand> Brands { get;}
    }
}

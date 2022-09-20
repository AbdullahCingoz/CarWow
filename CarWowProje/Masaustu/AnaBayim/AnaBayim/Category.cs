using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaBayim
{
    public class Category
    {
        public int ID { get; set; }

        [Required]
        [StringLength(maximumLength:50)]
        public string CategoryName { get; set; }

        [StringLength(maximumLength:100)]
        public string Description { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}
 
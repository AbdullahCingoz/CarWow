using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarWow.Models
{
    public class Manager
    {
        public int ID { get; set; }

        public int ManagerType_ID { get; set; }

        [ForeignKey("ManagerType_ID")]
        public virtual ManagerType ManagerType { get; set; }

        [Display(Name = "Isim")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 50, ErrorMessage = "Bu alan en fazla 50 karakter olmalıdır")]
        public string Name { get; set; }

        [Display(Name = "Soyisim")]
        [StringLength(maximumLength: 50, ErrorMessage = "Bu alan en fazla 50 karakter olmalıdır")]
        public string Surname { get; set; }

        [Display(Name = "Mail")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 50, ErrorMessage = "Bu alan en fazla 50 karakter olmalıdır")]
        public string Mail { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 50, ErrorMessage = "Bu alan en fazla 50 karakter olmalıdır")]
        public string Password { get; set; }

        [Display(Name = "Kayıt Tarihi")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Profil Resmi")]
        [StringLength(maximumLength: 50, ErrorMessage = "Bu alan en fazla 50 karakter olmalıdır")]
        public string ProfileImage { get; set; }

        [Display(Name = "Durum")]
        public bool Status { get; set; }
    }
}
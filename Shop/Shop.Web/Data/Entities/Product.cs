using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Data.Entities
{
    public class Product :IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Display(Name = "Last Purchase")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime LastPurchase { get; set; }

        [Display(Name = "Last Sale")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime LastSale { get; set; }

        [Display(Name = "Is Availabe?")]
        public bool IsAvailabe { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

        public User User { get; set; }

    }
}

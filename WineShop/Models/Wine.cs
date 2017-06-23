using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WineShop.Models
{
    public class Wine
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(25, ErrorMessage ="Name must be shorter that 25 characters")]
        public string Name { get; set; }

        [Range(10,200)]
        public double Price { get; set; }

        [Range(2000, 2999)]
        public int YearOfBotling { get; set; }

        [Range(8.5,22, ErrorMessage ="Alkoholpercentage must be betweeen 8.5 and 22%")]
        public double AlcoholPercentage { get; set; }

        
        public string ImagePath { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public WineType WineType { get; set; }

        [Display(Name = "Winery" )]
        public int WineryId { get; set; }

        public virtual Winery Winery { get; set; }



    }

    public enum WineType
    {
        Savignon, Rieslinger, Syrah, Merlot, Cabernet, Other
    }

}
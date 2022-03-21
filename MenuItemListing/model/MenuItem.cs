using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListing.model
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name="Free Delivery")]
       
        public Boolean FreeDelivery { get; set; }
        public Double Price { get; set; }
      
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd")]
       
         public DateTime DateOFLaunch { get; set; }
        public Boolean Active { get; set; }
    }
}

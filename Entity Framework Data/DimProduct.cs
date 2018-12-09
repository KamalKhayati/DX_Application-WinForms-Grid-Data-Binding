using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Entity_Framework_Data
{
    public class DimProduct
    {

        public int DimProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [DataType(DataType.Currency),Range(2000,5000)]
        public Nullable<decimal> Price { get; set; }
        [DataType(DataType.MultilineText),Display(Name = "Discreption")]
        public string ProductDiscreption { get; set; }
        [DataType(DataType.Text)]
        public Nullable<DateTime> StratDate { get; set; }
        [DataType(DataType.Date)]
        public Nullable<DateTime> EndDate { get; set; }
    }
}

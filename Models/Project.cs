using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace pjadv.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string productCode { get; set; }
        public string productName { get; set; }
        public string productLine { get; set; }
        public string productScale { get; set; }
        public string productVendor { get; set; }
        public string productDescription { get; set; }
        public int quantityInStock { get; set; }
        public double buyPrice { get; set; }
        public double salePrice { get; set; }
    }
}

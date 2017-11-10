
using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("ProductCategory")]
    public class ProductCategory
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string Color { get; set; }
    }
}

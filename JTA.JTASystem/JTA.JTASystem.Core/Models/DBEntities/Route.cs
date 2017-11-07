using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("Route")]
    public class Route
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}

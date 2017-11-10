using System.ComponentModel.DataAnnotations.Schema;

namespace JTA.JTASystem.Core
{
    [Table("CreditRating")]
    public class CreditRating
    {
        public int Id { get; set; }

        public string Rating { get; set; }

        public int MinimumScore { get; set; }

        public int MaximumScore { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuddyLendingShared.Model.MasterData
{
    public class InterestRateM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public double InterestRate { get; set; }
        public string InterestDesc { get; set; } = string.Empty;
    }
}

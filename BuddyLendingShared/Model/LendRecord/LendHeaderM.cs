using BuddyLendingShared.Model.Manpower;
using BuddyLendingShared.Model.MasterData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuddyLendingShared.Model.LendRecord
{
    public class LendHeaderM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string LendNo { get; set; } = string.Empty;
        public int ApplyCount { get; set; }
        public MemberModel? MemModel { get; set; }
        public int MemModelId { get; set; }
        public DateTime DateApply { get; set; }
        public string LendStatus { get; set; } = string.Empty;
        public int ReferralId { get; set; } 
        public string ReferralName { get; set; } = string.Empty;
        public double AmountApply { get; set; }
        public double AmountApproved { get; set; }
        public double AmountInterest { get; set; }
        public double AmountTotal { get; set; }
        public double AmountRemittance { get; set; }
        public InterestRateM? IntRateM { get; set; }
        public int IntRateMId { get; set; }
        public DateTime DateApproved { get; set; }
        public DateTime DateClosed { get; set; }

    }
}

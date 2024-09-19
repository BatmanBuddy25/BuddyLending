using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BuddyLendingShared.Model.Manpower
{
    public class MemberModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string MemberNo { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Civil { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
        public string CBU { get; set; } = string.Empty;
        public string MemStatus { get; set; } = string.Empty;
        public int ReferralId { get; set; }
        public string ReferralName { get; set; } = string.Empty;
    }
}

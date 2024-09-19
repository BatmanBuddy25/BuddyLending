using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BuddyLendingShared.Model.LendRecord
{
    public class LendDetailsM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string LendNo { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
        public DateTime PayDate { get; set; }
        public double LoanBalanceAmount { get; set; }
        public double RuturnAmount { get; set; }
        public double InterestAmount { get; set; }
        public double TotalAmount { get; set; }
        public string LendStatus { get; set; } = string.Empty;
        public string ReceiveName { get; set; } = string.Empty;
    }
}

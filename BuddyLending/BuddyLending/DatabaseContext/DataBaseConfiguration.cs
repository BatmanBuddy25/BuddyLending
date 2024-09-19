using BuddyLendingShared.Model.LendRecord;
using BuddyLendingShared.Model.Manpower;
using BuddyLendingShared.Model.MasterData;
using Microsoft.EntityFrameworkCore;

namespace BuddyLending.DatabaseContext
{
    public class DataBaseConfiguration : DbContext
    {
        public DataBaseConfiguration(DbContextOptions<DataBaseConfiguration> options) : base(options)
        {

        }

        //LendRecord
        public DbSet<LendHeaderM> LendHeaderTable { get; set; }
        public DbSet<LendDetailsM> LendDetailsTable { get; set; }

        //Manpower
        public DbSet<MemberModel> MemberTable { get; set; }

        //MasterData
        public DbSet<InterestRateM> InterestRateTable { get; set; }
    }
}

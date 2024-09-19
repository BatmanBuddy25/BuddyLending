using BuddyLending.DatabaseContext;
using BuddyLendingShared.Interfaces.IManpower;
using BuddyLendingShared.Model.Manpower;
using Microsoft.EntityFrameworkCore;

namespace BuddyLending.ImplementationRepo.MemberServiceRepo
{
    public class MemberRepo(DataBaseConfiguration context) : IMemberService
    {
        private readonly DataBaseConfiguration _context = context;

        public async Task<List<MemberModel>> GetMasterList() => await _context.MemberTable.ToListAsync();
      
        public async Task InsertMember(MemberModel _obj)
        {
            _context.MemberTable.Add(_obj);
            await _context.SaveChangesAsync();
        }
    }
}

using BuddyLendingShared.Model.Manpower;

namespace BuddyLendingShared.Interfaces.IManpower
{
    public interface IMemberService
    {
        Task InsertMember(MemberModel _obj);
        Task<List<MemberModel>> GetMasterList();
    }
}

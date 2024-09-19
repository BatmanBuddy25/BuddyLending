using BuddyLendingShared.Model.Manpower;
using Microsoft.AspNetCore.Components;

namespace BuddyLending.Client.Pages.MemberPages
{
    public partial class MemberInfoPage : ComponentBase
    {
        public MemberModel Obj = new MemberModel();

        private async Task OnInsertData()
        {
            await _memberService.InsertMember(Obj);

            _navigation.NavigateTo("/member-list");
        }
    }
}

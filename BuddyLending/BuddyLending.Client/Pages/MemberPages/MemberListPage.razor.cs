using BuddyLendingShared.Model.Manpower;
using Microsoft.AspNetCore.Components;

namespace BuddyLending.Client.Pages.MemberPages
{
    public partial class MemberListPage : ComponentBase
    {
        public List<MemberModel> Member_List = [];
        public MemberModel Obj = new MemberModel();

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(1);

            Member_List = await _memberService.GetMasterList();
        }

        private async Task OnInsertData()
        {
            await _memberService.InsertMember(Obj);
        }

        private async Task OnAddMember()
        {
            await Task.Delay(1);
            _navigation.NavigateTo("/member-info");
        }
    }
}

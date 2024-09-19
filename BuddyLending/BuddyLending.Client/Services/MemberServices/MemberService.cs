using BuddyLendingShared.Interfaces.IManpower;
using BuddyLendingShared.Model.Manpower;
using System.Net.Http.Json;

namespace BuddyLending.Client.Services.MemberServices
{
    public class MemberService(HttpClient httpClient) : IMemberService
    {
        private readonly HttpClient _httpClient = httpClient;

        public async Task<List<MemberModel>> GetMasterList()
        {
            var _response = await _httpClient.GetAsync("api/Members/Getmasterlist");
            var _masterlist = await _response.Content.ReadFromJsonAsync<List<MemberModel>>();
            return _masterlist!;
        }

        public async Task InsertMember(MemberModel _obj)
        {
            await _httpClient.PostAsJsonAsync("api/Members/Postobj", _obj);
        }
    }
}

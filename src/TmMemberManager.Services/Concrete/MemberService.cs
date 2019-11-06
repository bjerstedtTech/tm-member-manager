using System.Threading.Tasks;
using TmMemberManager.Data;
using TmMemberManager.Services.Models;

namespace TmMemberManager.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberDataService _dataService;

        public MemberService(IMemberDataService dataService)
        {
            _dataService = dataService;
        }

        public async Task<MemberModel> GetMember(int? tmMemberNumber = null, int? clubMemberNumber = null)
        {
            MemberModel member = null;
            if (tmMemberNumber.HasValue) {
                member = await _dataService.GetMemberByTmMemberNumber(tmMemberNumber.Value);
                if (member != null && clubMemberNumber.HasValue && member.ClubMemberNumber != clubMemberNumber.Value)
                    member = null;
            } else if (clubMemberNumber.HasValue) {
                member = await _dataService.GetMemberByClubMemberNumber(clubMemberNumber.Value);
            }
            return member;
        }
    }
}

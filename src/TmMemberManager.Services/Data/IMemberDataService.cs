using System.Threading.Tasks;
using TmMemberManager.Services.Models;

namespace TmMemberManager.Data
{
    public interface IMemberDataService
    {
        Task<MemberModel> GetMemberByTmMemberNumber(int tmMemberNumber);
        Task<MemberModel> GetMemberByClubMemberNumber(int tmMemberNumber);
    }
}

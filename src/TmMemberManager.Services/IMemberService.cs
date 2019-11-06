using System.Threading.Tasks;
using TmMemberManager.Services.Models;

namespace TmMemberManager.Services
{
    public interface IMemberService
    {
        Task<MemberModel> GetMember(int? tmMemberNumber = null, int? clubMemberNumber = null);
    }
}
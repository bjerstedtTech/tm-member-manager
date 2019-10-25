using System.Threading.Tasks;
using TmMemberManager.Services.Models;

namespace TmMemberManager.Services
{
    public interface IMemberService
    {
        Task<MemberModel[]> GetMembers();
    }
}
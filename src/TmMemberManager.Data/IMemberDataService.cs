using System.Linq;
using System.Threading.Tasks;
using TmMemberManager.Data.Entities;

namespace TmMemberManager.Data
{
    public interface IMemberDataService
    {
        IQueryable<Member> AllMembers();
        void Add(Member member);
    } 
}

using System.Linq;
using System.Threading.Tasks;
using TmMemberManager.Data;
using TmMemberManager.Data.Entities;
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

        public IMemberService Add(MemberModel model)
        {
            if (model.TmMemberId.HasValue
                && _dataService.AllMembers().Any(m => m.TmMemberNumber == model.TmMemberId.Value))
                throw new DuplicateKeyException("TmMemberNumber", "Member");

            var entity = new Member {
                TmMemberNumber = model.TmMemberId,
                TmMemberName = $"{model.FirstName} {model.LastName}",
                FirstName = model.FirstName,
                LastName = model.LastName,
                PrimaryEmail = model.PrimaryEmail
            };

            _dataService.Add(entity);
            return this;
        }
    }
}

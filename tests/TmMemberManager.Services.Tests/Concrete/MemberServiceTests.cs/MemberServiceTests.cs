using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using TmMemberManager.Data;
using TmMemberManager.Services.Models;

namespace TmMemberManager.Services.Concrete.Tests
{
    public class MemberServiceTests
    {
        [Test]
        [TestCase(null, null, ExpectedResult = null)]
        [TestCase(99001, null, ExpectedResult = "Henry")]
        [TestCase(99001, 51, ExpectedResult = "Henry")]
        [TestCase(99001, 52, ExpectedResult = null)]
        [TestCase(null, 52, ExpectedResult = null)]
        [TestCase(99002, null, ExpectedResult = null)]
        [TestCase(null, 51, ExpectedResult = "Henry")]
        public async Task<string> GetMemberReturnsExectedResult_For(int? tmValue, int? clubValue)
        {
            var svc = SetupMemberService(ModelOfHenry);
            var member = await svc.GetMember(tmMemberNumber: tmValue, clubMemberNumber: clubValue);
            return member?.FirstName;
        }

        private MemberService SetupMemberService(params MemberModel[] members)
        {
            var mockDataService = Substitute.For<IMemberDataService>();
            foreach (var member in members) {
                mockDataService.GetMemberByTmMemberNumber(Arg.Is<int>(n => n == member.TmMemberNumber))
                    .Returns(ci => Task.FromResult(member));
                mockDataService.GetMemberByClubMemberNumber(Arg.Is<int>(n => n == member.ClubMemberNumber))
                    .Returns(ci => Task.FromResult(member));
            }

            return new MemberService(mockDataService);
        }

        private static MemberModel ModelOfHenry = new MemberModel {
            TmMemberNumber = 99001,
            ClubMemberNumber = 51,
            FirstName = "Henry"
        };
    }
}

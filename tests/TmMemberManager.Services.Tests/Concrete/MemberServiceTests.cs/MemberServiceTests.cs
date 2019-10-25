using System.Threading.Tasks;
using NUnit.Framework;

namespace TmMemberManager.Services.Concrete.Tests
{
    public class MemberServiceTests
    {
        [Test]
        public async Task Test1()
        {
            var svc = new MemberService();
            var list = await svc.GetMembers();

            Assert.That(list, Is.Not.Null);
        }
    }
}
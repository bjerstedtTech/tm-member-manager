using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using TmMemberManager.Data.Entities;

namespace TmMemberManager.Data.Tests
{
    public class MemberTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            
        }

        private MemberManagerContext SetupContext()
        {
            var options = new DbContextOptionsBuilder<MemberManagerContext>()
                .UseInMemoryDatabase(databaseName:"TestMembers")
                .Options;

            var context = new MemberManagerContext(options);

//            context.Members.Add()

            return context;
        }
    }
}

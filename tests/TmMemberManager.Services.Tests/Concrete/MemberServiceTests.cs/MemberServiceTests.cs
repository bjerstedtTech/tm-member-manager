using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using TmMemberManager.Data;
using TmMemberManager.Data.Entities;
using TmMemberManager.Services.Models;

namespace TmMemberManager.Services.Concrete.Tests
{
    [TestFixture]
    public class MemberServiceTests
    {
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void AddMember_ShouldSucceed(int count)
        {
            var dataSvc = new MockMameberDataService();
            var sut = new MemberService((IMemberDataService)dataSvc);

            foreach (var m in _membersToAdd.Take(count)) sut.Add(m);

            Assert.That(dataSvc.Members.Count(), Is.EqualTo(count));
            Assert.That(
                dataSvc.Members.Select(m => m.TmMemberNumber),
                Is.EquivalentTo(_membersToAdd.Take(count).Select(m => m.TmMemberId))
                );
        }

        [Test]
        public void AddDuplicateMemberWithId_ShouldThrow_DuplicateKeyException()
        {
            var dataSvc = new MockMameberDataService();
            var sut = new MemberService((IMemberDataService)dataSvc);
            
            sut.Add(_membersToAdd[0]);
            Assert.That(
                () => sut.Add(_membersToAdd[0]),
                Throws.TypeOf<DuplicateKeyException>()
            );
        }

        [Test]
        public void AddDuplicateMemberWithNullId_ShouldSucceed()
        {
            var dataSvc = new MockMameberDataService();
            var sut = new MemberService((IMemberDataService)dataSvc);
            
            sut.Add(_janeway);
            sut.Add(_janeway);
        }

        private static MemberModel[] _membersToAdd = new MemberModel[] {
            NewMember(1, "James", "Kirk"),
            NewMember(2, "Leonard", "McCoy"),
            NewMember(3, "Montgomery", "Scott"),
            NewMember(4, "Jean Luc", "Picard"),
            NewMember(5, "Beverly", "Crusher"),
        };

        private static MemberModel _janeway = NewMember(null, "Kathryn", "Janeway");

        private static MemberModel NewMember(int? id, string fName, string lName)
        {
            return new MemberModel {
                TmMemberId = id,
                FirstName = fName,
                LastName = lName,
                PrimaryEmail = $"{fName}.{lName}@test.org"
            };
        }
    }

    public class MockMameberDataService : IMemberDataService
    {
        public readonly List<Member> Members = new List<Member>();
        private int _nextId = 0;

        void IMemberDataService.Add(Member member)
        {
            Members.Add(member);
        }

        IQueryable<Member> IMemberDataService.AllMembers()
        {
            return Members.AsQueryable();
        }
    }
}

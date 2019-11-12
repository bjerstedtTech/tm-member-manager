using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace TmMemberManager.Data.Entities
{
    public class MemberManagerContext : DbContext
    {
        #region Constructors

        public MemberManagerContext() : base() { }

        public MemberManagerContext(DbContextOptions<MemberManagerContext> options)
        : base(options) { }

        #endregion

        #region Entitis

        public DbSet<Member> Members {get;set;}

        #endregion

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Member>()
                .HasKey(m => m.MemberId);
            mb.Entity<Member>()
                .HasAlternateKey(m =>m.TmMemberNumber);
        }
    }

    public class Member
    {
        [Required][Range(1, int.MaxValue)]
        public int MemberId {get;set;}

        public int? TmMemberNumber {get;set;}
        
    }
}

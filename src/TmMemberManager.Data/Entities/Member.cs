using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace TmMemberManager.Data.Entities
{
    public class Member
    {
        public int MemberId { get; set; }

        public int? TmMemberNumber { get; set; }

        public string TmMemberName { get; set; }

        public string FirstName{get;set;}

        public string LastName{get;set;}

        public string PrimaryEmail{get;set;}

    }
}

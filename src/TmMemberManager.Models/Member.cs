using System;

namespace TmMemberManager.Models
{
    /// <summary>
    /// Public information available for a member
    /// </summary>
    public class Member
    {
        /// <summary>
        /// Official member number on Toastmaster's roster.
        /// </summary>
        public int TmMemberNumber { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email {get;set;}

        /// <summary>
        /// Indicates that member is current member and listed on official roster.
        /// </summary>
        public bool IsCurrent{get;set;}

        /// <summary>
        /// Indicates that member is currently active. Members may stop coming, but
        /// remain on club roster.
        /// </summary>
        public bool IsActive {get;set;}

        /// <summary>
        /// Indicates that member is paid uo for current period.
        /// </summary>
        public bool IsPaid{get;set;}
    }
}

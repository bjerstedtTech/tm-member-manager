using System;

namespace TmMemberManager.Services.Models
{
    /// <summary>
    /// Public information available for a member
    /// </summary>
    public class MemberModel
    {
        /// <summary>
        /// Member number assigned by local club
        /// </summary>
        public int ClubMemberId { get; set; }

        /// <summary>
        /// Official member number on Toastmaster's roster.
        /// </summary>
        public int? TmMemberId { get; set; }

        /// <summary>
        /// Preferred name (Tony vs Anthony)
        /// </summary>
        public string? PreferredName { get; set; }

        /// <summary>
        /// First Name as it appears on roster
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name as it appears on roster
        /// </summary>
        public string LastName { get; set; }
        public string PrimaryEmail { get; set; }


        /// <summary>
        /// Indicates that member is current member and listed on official roster.
        /// </summary>
        public bool IsCurrent { get; set; }

        /// <summary>
        /// Indicates that member is currently active. Members may stop coming, but
        /// remain on club roster.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Indicates that member is paid uo for current period.
        /// </summary>
        public bool IsPaid { get; set; }
    }
}

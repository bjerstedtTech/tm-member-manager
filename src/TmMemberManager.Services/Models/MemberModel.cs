using System;

namespace TmMemberManager.Services.Models
{
    /// <summary>
    /// Public information available for a member
    /// </summary>
    public class MemberModel
    {
        /// <summary>
        /// Official member number on Toastmaster's roster.
        /// </summary>
        public int? TmMemberId { get; set; }

        /// <summary>
        /// First Name as it appears on roster
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name as it appears on roster
        /// </summary>
        public string LastName { get; set; }
        public string PrimaryEmail { get; set; }
    }
}

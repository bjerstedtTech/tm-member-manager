using System;

namespace TmMemberManager.Services.Models
{
    /// <summary>
    /// Roles that a member can perform at a meeting
    /// </summary>
    public class Role
    {
        public string RoleCode { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public string Group { get; set; }
        public int GroupRank { get; set; }
    }
}

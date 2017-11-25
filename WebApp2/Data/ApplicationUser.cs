using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApp2.Data
{
    /// <summary>
    /// 1. Enable-Migrations
    /// 2. Add-Migration "abc"
    /// 3. Update-Database
    /// </summary>

    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string RegisterCode { get; set; }

        public virtual UserSetting UserSetting { get; set; }
    }

    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole(string name, string description) : base(name)
        {
            this.Description = description;
        }

        public string Description { get; set; }
    }

    public class UserSetting
    {
        [Key]
        public int UserSettingId { get; set; }

        [StringLength(50)]
        [Display(Name = "Language")]
        public string Language { get; set; }

        [StringLength(50)]
        [Display(Name = "Theme")]
        public string Theme { get; set; }
    }
}

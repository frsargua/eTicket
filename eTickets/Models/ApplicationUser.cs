using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace eTickets.Models
{
	public class ApplicationUser:IdentityUser
	{
        [Display(Name = "full name")]
        public string FullName { get; set; }
    }
}


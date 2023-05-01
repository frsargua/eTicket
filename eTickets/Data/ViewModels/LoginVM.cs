using System;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Data.ViewModels
{
	public class LoginVM
	{
		[Display(Name ="Email address")]
		[Required(ErrorMessage ="Email address is required")]
		public string EmailAddres { get; set; }

        [Required]
		[DataType(DataType.Password)]
        public string Password { get; set; }

    }
}


using System;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
	public class Cinema
	{
        [Key]
        public int Id { set; get; }

        public string Logo { set; get; }

        public string Name { set; get; }

        public string Description { set; get; }

    }
}



using System;
using System.ComponentModel.DataAnnotations;
using eTickets.Data;

namespace eTickets.Models
{
	public class Movie
	{
        [Key]
        public int Id { set; get; }

        public string Name { set; get; }

        public string Description { set; get; }

        public double Price { set; get; }

        public DateTime StartDate { set; get; }

        public DateTime EndDate { set; get; }

        public MovieCategory MovierCategory { get; set; }

    }
}


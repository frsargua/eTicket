
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

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }

    }
}


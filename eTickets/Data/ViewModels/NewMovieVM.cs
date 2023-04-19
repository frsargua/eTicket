using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        [Required(ErrorMessage = "Name is required")]
        [Display(Description="Movie Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [Display(Description = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price in $")]
        [Display(Description = "Price")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Movie poster URL")]
        [Display(Description = "Movie poster URL is required")]
        public string ImageURL { get; set; }

        [Required(ErrorMessage = "Movie start date")]
        [Display(Description = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Movie end date")]
        [Display(Description = "End date is required")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Select a category")]
        [Display(Description = "Movie category is required")]
        public MovieCategory MovieCategory { get; set; }

        [Required(ErrorMessage = "Select actor(s)")]
        [Display(Description = "Movie actor(s) is required")]
        public List<int> ActorIds { get; set; }

        [Required(ErrorMessage = "Select cinema(s)")]
        [Display(Description = "Movie cinema is required")]
        public int CinemaId { get; set; }

        [Required(ErrorMessage = "Select producer")]
        [Display(Description = "Movie producer is required")]
        public int ProducerId { get; set; }

    }
}
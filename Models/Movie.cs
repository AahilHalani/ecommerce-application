using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Movie Name")]

        public string? Name { get; set; }
        [Display(Name = "Description")]

        public string? Description { get; set; }
        public double Price { get; set; }
        [Display(Name = "Movie Picture")]
        public string? ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        
        //relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }
        //public List<Actor>? Actors { get; set; }

        //cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema? Cinema { get; set; }

        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]

        public Producer? Producer { get; set;}
    }
}

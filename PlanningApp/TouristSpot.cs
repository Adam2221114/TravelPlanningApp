using System.ComponentModel.DataAnnotations;

namespace PlanningApp
{
    public class TouristSpot
    {
        [Key]
        public int Id { get; set; }

        [Required] // Indicates that this attribute is required and does not allow empty values
        [MaxLength(100)] // Limit the maximum length of the string to 100
        public string Name { get; set; }

        [MaxLength(255)]
        public string ImagePath { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [MaxLength(200)]
        public string Location { get; set; } 

        [Range(0, 5)]
        public double Rating { get; set; }

        // Used to count the number of times the attraction has been collected, reflecting the popularity of the attraction
        public int PopularityCount { get; set; } = 0;
    }
}
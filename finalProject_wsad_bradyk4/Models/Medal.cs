using System.ComponentModel.DataAnnotations;

namespace finalProject_wsad_bradyk4.Models
{
    public class Medal
    {
        public int MedalId { get; set; }
        [Required(ErrorMessage = "Please enter the competition name.")] public string Event { get; set; }
        [Required(ErrorMessage = "Please enter the athletes name.")] public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a year.")] [Range(1889, 2999, ErrorMessage = "Year must be after 1889.")] public int? Year { get; set; }
        [Required(ErrorMessage = "Please enter a rating.")] [Range(1, 5, ErrorMessage = "Place must be between 1 and 5.")] public int? Place { get; set; }
    }
}
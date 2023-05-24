using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models
{
    public class Platform
    {
        [Key]
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [MaxLength(200, ErrorMessage = "Maximum length for publisher is 200 characters.")]
        [Required(ErrorMessage = "Publisher is required")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Cost is required")]
        public string Cost { get; set; }
    }
}
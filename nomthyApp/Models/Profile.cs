using System.ComponentModel.DataAnnotations;

namespace nomthyApp.Models
{
    public class Profile
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        [Display(Name = "Year of Study")]
        public int Year { get; set; }

        [Display(Name = "Course")]
        public string Course { get; set; }

        [Url]
        [Display(Name = "GitHub Profile")]
        public string GitHubUrl { get; set; }

        [Url]
        [Display(Name = "LinkedIn Profile")]
        public string LinkedInUrl { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePicturePath { get; set; }

        public string UserId { get; set; }

        public DateTime LastUpdated { get; set; }

        [Display(Name = "DUT Logo")]
        public string SchoolLogoPath { get; set; } = "/images/dut-logo.png";
    }
}

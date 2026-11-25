using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SpeakSmartAI.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        [StringLength(500)]
        public string? AvatarUrl { get; set; }

        [StringLength(20)]
        public string EnglishLevel { get; set; } = "Beginner";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
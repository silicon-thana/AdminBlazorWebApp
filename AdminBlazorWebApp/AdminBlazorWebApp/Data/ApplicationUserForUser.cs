using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AdminBlazorWebApp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUserForUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Biography { get; set; }
        public string? ProfileImg { get; set; }
        public int? AddressId { get; set; }
        public AddressEntity? Address { get; set; }
        public bool IsSubscribed { get; set; }
        public bool IsDarkTheme { get; set; }
        public string? NotificationEmail { get; set; }


    }

    public class AddressEntity
    {
        [Key]
        public int Id { get; set; }
        public string AddressLine_1 { get; set; } = null!;
        public string? AddressLine_2 { get; set; }
        public string PostalCode { get; set; } = null!;
        public string City { get; set; } = null!;
    }
}

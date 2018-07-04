using System.ComponentModel.DataAnnotations;

namespace ZBot.Models
{
    public class ZBotUser
    {
        [Required]
        public string Id { get; set; } = "";

        [Required]
        [EmailAddress]
        public string Email { get; set; } = "name@email.com";

        [Required]
        public string Username { get; set; } = "TWITCH_USER";

        public ZBotUser(string id, string email, string username)
        {
            Id = id;
            Email = email;
            Username = username;
        }
    }
}

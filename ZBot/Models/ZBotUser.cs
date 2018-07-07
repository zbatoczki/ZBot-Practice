using System.ComponentModel.DataAnnotations;

namespace ZBot.Models
{
    public class ZBotUser
    {
        [Required]
        [Key]
        public int UserId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = "name@email.com";

        [Required]
        public string Username { get; set; } = "TWITCH_USER";

        public string OAuthToken { get; set; }
        public string RefreshToken { get; set; }

        public ZBotUser(int id, string email, string username, string oAuthToken, string refreshToken)
        {
            UserId = id;
            Email = email;
            Username = username;
            OAuthToken = oAuthToken;
            RefreshToken = refreshToken;
        }
    }
}

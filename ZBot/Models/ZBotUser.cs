using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZBot.Models
{
    public class ZBotUser
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = "name@email.com";

        [Required]
        public string Username { get; set; } = "TWITCH_USER";

        public ZBotUser(string email, string username)
        {
            Email = email;
            Username = username;
        }

        public ZBotUser()
        {
        }
    }
}

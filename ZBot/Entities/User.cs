using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZBot.Entities
{
    public class User
    {

        [Key]
        public string UserId { get; set; } 

        public string Email { get; set; }

        public string Username { get; set; }

        public Token Token { get; set; }
    }
}

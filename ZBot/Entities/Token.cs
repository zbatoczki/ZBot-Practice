using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZBot.Entities
{
    public class Token
    {
        [Key]
        public int Id { get; set; }

        //foreign key
        public User User { get; set; } //relationship to User entity (one-to-one)

        public string oAuthToken { get; set; }
        public string refreshToken { get; set; }
    }
}

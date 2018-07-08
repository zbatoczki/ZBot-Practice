using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZBot.Entities
{
    public class Token
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        //foreign key
        public string UserId { get; set; }
        public User User { get; set; } //relationship to User entity (one-to-one)

        public string OAuthToken { get; set; }
        public string RefreshToken { get; set; }
    }
}

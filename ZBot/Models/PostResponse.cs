using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZBot.Models
{
    public class PostResponse
    {
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public string expires_in { get; set; }
        public string scope { get; set; }
    }
}

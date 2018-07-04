using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZBot.Services
{
    public interface IWebRequest
    {
        string MakeRequest(string requestType, string url, Dictionary<string, string> parameters = null);
    }
}

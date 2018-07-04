using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ZBot.Services
{
    public class WebRequest : IWebRequest
    {
        private readonly HttpClient client = new HttpClient();

        /// <summary>
        /// Makes a GET or POST request with the provided URL
        /// </summary>
        /// <param name="requestType">Type of request, such as "GET" or "POST".</param>
        /// <param name="url">The target URL.</param>
        /// <param name="parameters">Parameters for the request.</param>
        public string MakeRequest(string requestType, string url, Dictionary<string, string> parameters = null)
        {
            string response = "";
            if (requestType == "GET")
            {
                response = client.GetStringAsync(url).Result;
            }
            else if (requestType == "POST")
            {
                var encodedContent = new FormUrlEncodedContent(parameters);
                var postResponse = client.PostAsync(url, encodedContent).Result;
                if(postResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    response = postResponse.Content.ReadAsStringAsync().Result;
                }
            }


            return response;
        }

    }
}

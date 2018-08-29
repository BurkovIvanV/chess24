using System.Collections.Generic;
using System.Net.Http;

namespace APIClient
{
    public class RequestParameters
    {
        private Dictionary<string, string> parameters { get; set; }

        public RequestParameters()
        {
            parameters["token"] = "32553a4b-e29f-4d77-88e0-383dad817ef2";
        }

        public FormUrlEncodedContent Content => new FormUrlEncodedContent(parameters);
    }
}

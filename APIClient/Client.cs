using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace APIClient
{
    public class Client
    {
        protected const string ApiLink = "http://shpora.skbkontur.ru:80";
        private readonly HttpClient client = new HttpClient();
        private readonly RequestParameters requestParameters;

        public Client(RequestParameters requestParameters)
        {
            this.requestParameters = requestParameters;
        }

        public async Task StartGame()
        {
            var url = ApiLink + "/task/game/start";
            var response = await client.PostAsync(url, requestParameters.Content);
        }

        public async Task EndGame()
        {
            var url = ApiLink + "/task/game/finish";
            var response = await client.PostAsync(url, requestParameters.Content);
        }

        public async Task GetStats()
        {
            var url = ApiLink + "/task/game/stats";
            var response = await client.GetAsync(url, requestParameters.Content);
        }
    }
}

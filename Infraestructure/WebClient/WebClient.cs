using Core.HttpClient;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Infraestructure.WebClient
{
    public class WebClient : IWebClient
    {
        private HttpClient _client;
        private string _baseUrl;
        
        public WebClient(string baseUrl) 
        {
            _baseUrl = baseUrl;
            _client = new HttpClient();
        }
        public async Task<T> GetContent<T>(string endPoint) 
        {
            var getResult = await _client.GetAsync($"{_baseUrl}{endPoint}");        
                       
            getResult.EnsureSuccessStatusCode();

            var streamResult =  await getResult.Content.ReadAsStreamAsync();

            var result = await JsonSerializer.DeserializeAsync<T>(streamResult);                 

            return result;
        }
    }
}

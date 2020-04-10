using Assignment.AggregatorService.IService;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Assignment.AggregatorService.Services
{
    public class FetchOrderDetailService: IFetchOrderDetailService
    {
        private readonly IConfiguration _configuration;
        public FetchOrderDetailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<object> GetUserDetails()
        {
            var url= _configuration.GetValue<string>("UserService:Url")+"/api/user/1";
            using (HttpClient client = new HttpClient())
            {
                var responseMessage = await client.GetAsync(url);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var response = await responseMessage.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<object>(response);
                    return result;
                }
            }
            return null;
        }

        public async Task<IEnumerable<object>> GetOrderDetails()
        {
            var url = _configuration.GetValue<string>("OrderService:Url") + "/api/order/1";
            using (HttpClient client = new HttpClient())
            {
                var responseMessage = await client.GetAsync(url);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var response = await responseMessage.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<IEnumerable<object>>(response);
                    return result;
                }
            }
            return null;
        }
    }
}

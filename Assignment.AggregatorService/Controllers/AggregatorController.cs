using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.AggregatorService.IService;
using Assignment.AggregatorService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.AggregatorService.Controllers
{
    [Route("api/orderdetails")]
    [ApiController]
    public class AggregatorController : ControllerBase
    {
        private readonly IFetchOrderDetailService _fetchOrderDetailService;
        public AggregatorController(IFetchOrderDetailService fetchOrderDetailService)
        {
            _fetchOrderDetailService = fetchOrderDetailService;
        }
        [HttpGet("{id}")]
        public ActionResult<AggregatedResponse> Get(int id)
        {
            var aggregatedReponse = new AggregatedResponse();
            var userInfo = _fetchOrderDetailService.GetUserDetails().Result;
            var orderInfo = _fetchOrderDetailService.GetOrderDetails().Result;
            aggregatedReponse.UserDetails = userInfo;
            aggregatedReponse.Orders = orderInfo;
            return aggregatedReponse;
        }
    }
}
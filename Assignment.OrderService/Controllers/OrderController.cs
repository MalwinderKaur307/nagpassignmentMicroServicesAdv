using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.OrderService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.OrderService.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Order>> Get(int id)
        {
            return new List<Order>
            {
                new Order
                {
                     OrderId=1,
                     OrderAmount=250,
                     OrderDate="14-Apr-2020"
                },
                new Order
                {
                     OrderId=2,
                     OrderAmount=450,
                     OrderDate="15-Apr-2020"
                }
            };
        }
    }
}
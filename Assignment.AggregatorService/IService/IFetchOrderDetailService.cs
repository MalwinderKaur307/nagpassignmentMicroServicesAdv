using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.AggregatorService.IService
{
    public interface IFetchOrderDetailService
    {
        Task<object> GetUserDetails();
        Task<IEnumerable<object>> GetOrderDetails();
    }
}

using Assignment.UserService.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.UserService.IService
{
    public interface IFetchUserService
    {
        User GetUser();
    }
}

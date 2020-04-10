using Assignment.UserService.DatabaseModels;
using Assignment.UserService.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.UserService.Service
{
    public class FetchUserService : IFetchUserService
    {
        private readonly AssignmentNagpContext _context;
        public FetchUserService(AssignmentNagpContext context)
        {
            _context = context;
        }

        public User GetUser()
        {
            var user = _context.User.FirstOrDefault();
            return user;
        }
    }
}

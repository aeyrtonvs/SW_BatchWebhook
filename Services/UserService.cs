using SW_APIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SW_APIS.Services
{
    public class UserService : IUserService
    {
        List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() {User = "user@mail.com", Password = "12345"}
        };
        public async Task<bool> Authenticate (string email, string password) => 
            Users.Any(l => l.User == email && l.Password == password);
    }
}

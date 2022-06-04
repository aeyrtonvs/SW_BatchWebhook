using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SW_APIS.Services
{
    public interface IUserService
    {
        Task<bool> Authenticate(string email, string password);
    }
}

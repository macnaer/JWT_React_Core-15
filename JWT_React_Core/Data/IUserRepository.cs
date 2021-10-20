using JWT_React_Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_React_Core.Data
{
    public interface IUserRepository
    {
        User Create(User user);
    }
}

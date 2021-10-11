using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICourse.Entities;

namespace WebAPICourse.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}

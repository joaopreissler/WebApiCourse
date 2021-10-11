using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICourse.DTOs;

namespace WebAPICourse.Interfaces
{
    public interface ITest
    {
        public Task<MemberDto> GetUser(int Id);
    }
}

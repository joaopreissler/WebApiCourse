using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICourse.DTOs;
using WebAPICourse.Entities;
using WebAPICourse.Helpers;

namespace WebAPICourse.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams);
        Task<AppUser> GetUserByUsernameAsync(string username);
        
        Task<MemberDto> GetMemberAsync(string username);
    }
}

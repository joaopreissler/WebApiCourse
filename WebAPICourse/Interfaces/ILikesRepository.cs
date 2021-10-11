using WebAPICourse.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPICourse.Entities;
using WebAPICourse.Helpers;

namespace WebAPICourse.Interfaces
{
    public interface ILikesRepository
    {
            Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
            Task<AppUser> GetUserWithLikes(int userId);
            Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesparams);
    }
}
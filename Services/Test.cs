using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICourse.Data;
using WebAPICourse.DTOs;
using WebAPICourse.Interfaces;

namespace WebAPICourse.Services
{
    public class Test : ITest
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public Test(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<MemberDto> GetUser(int Id)
        {
            return await _context.Users.Where(x => x.Id == Id).ProjectTo<MemberDto>(_mapper.ConfigurationProvider).SingleOrDefaultAsync();
        }
    }
}

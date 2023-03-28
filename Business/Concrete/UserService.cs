using AutoMapper;
using Business.Abstract;
using Business.Models.BaseDTO;
using Business.Models.BaseListDto;
using DataAccess.Entities;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;
        private readonly IMapper _mapper;

        public UserService(IRepository<User> repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<UsersDto>> GetAllAsync()
        {
            var table = await Task.Run(() => _repository.AsNoTracking
            .Include(x => x.Gender)
            .Include(y => y.BranchOffice).ToListAsync());
            var dto = _mapper.Map<List<User>, List<UsersDto>>(table);
            return  dto;


        }

    }
}

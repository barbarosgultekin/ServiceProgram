using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Models.BaseDTO;
using Business.Models.BaseListDto;
using Business.Repositories;
using DataAccess.Entities;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{

    public class GenderService : ServiceRepository<Gender, GenderDto>, IGenderService
    {
        private readonly IRepository<Gender> _repository;
        private readonly IMapper _mapper;

        public GenderService(IRepository<Gender> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GendersDto>> GetAllAsync()
        {
            var table = await _repository.Table.ToListAsync();
            var dto = _mapper.Map<List<Gender>, List<GendersDto>>(table);
            return dto;
        }
    }
}
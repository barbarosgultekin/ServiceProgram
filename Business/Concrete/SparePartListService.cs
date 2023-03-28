using AutoMapper;
using Business.Abstract;
using Business.Models.BaseDTO;
using Business.Repositories;
using DataAccess.Entities;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SparePartListService : ServiceRepository<SparePartList, SparePartListDto>, ISparePartListService
    {
        private readonly IRepository<SparePartList> _repository;
        private readonly IMapper _mapper;

        public SparePartListService(IRepository<SparePartList> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<SparePartListDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}

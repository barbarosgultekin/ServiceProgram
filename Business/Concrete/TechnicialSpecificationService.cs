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
    public class TechnicialSpecificationService : ServiceRepository<TechnicialSpecification, TechnicialSpecificationDto>, ITechnicialSpecificationService
    {
        private readonly IRepository<TechnicialSpecification> _repository;
        private readonly IMapper _mapper;

        public TechnicialSpecificationService(IRepository<TechnicialSpecification> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<TechnicialSpecificationDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}

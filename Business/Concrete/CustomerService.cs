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
    public class CustomerService : ServiceRepository<Customer, CustomerDto>, ICustomerService
    {
        private readonly IRepository<Customer> _repository;
        private readonly IMapper _mapper;

        public CustomerService(IRepository<Customer> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<CustomerDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}

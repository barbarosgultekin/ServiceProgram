using API.Repository;
using Business.Abstract;
using Business.Models.BaseDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{

    public class ProductsController : ControllerRepository<IProductService, ProductDto>
    {
        private readonly IProductService _service;
        public ProductsController(IProductService service) : base(service)
        {
            _service = service;
        }
    }
}

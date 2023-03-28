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
    public class TechnicialSpecificationController : ControllerRepository<ITechnicialSpecificationService, TechnicialSpecificationDto>
    {
        private readonly ITechnicialSpecificationService _service;
        public TechnicialSpecificationController(ITechnicialSpecificationService service) : base(service)
        {
            _service = service;
        }
    }
}



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

    public class SparePartListController : ControllerRepository<ISparePartListService, SparePartListDto>
    {
        private readonly ISparePartListService _service;
        public SparePartListController(ISparePartListService service) : base(service)
        {
            _service = service;
        }
    }
}



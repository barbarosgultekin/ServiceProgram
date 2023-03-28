﻿using Business.Models.BaseDTO;
using Business.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService:IServiceRepository<ProductDto>
    {
        Task<List<ProductDto>> GetAllAsync();
    }
}

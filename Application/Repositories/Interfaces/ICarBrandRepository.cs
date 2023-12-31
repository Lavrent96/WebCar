﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Interfaces
{
    public interface ICarBrandRepository : IRepository<CarBrand>
    {
        Task<CarBrand> GetByIdAsync(int id);
    }
}

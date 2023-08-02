﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Interfaces
{
    public interface ITireRepository : IRepository<Tire>
    {
        Task<Tire> GetByIdAsync(int id);

    }
}

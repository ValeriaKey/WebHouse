﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHouse.Core.Domain;
using WebHouse.Core.Dtos;

namespace WebHouse.Core.ServiceInterface
{
    public interface IHouseService
    {
        Task<House> Delete(Guid id);
        Task<House> Add(HouseDto dto);
        Task<House> Edit(Guid id);
        Task<House> Update(HouseDto dto);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OrderRepository:GenericDataRepository<Order>, IOrderRepository
    {
    }
    public interface IOrderRepository : IGenericDataRepository<Order>
    {
    }
}

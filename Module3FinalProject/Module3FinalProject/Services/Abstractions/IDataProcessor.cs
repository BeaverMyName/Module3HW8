﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module3FinalProject.Models;

namespace Module3FinalProject.Services.Abstractions
{
    public interface IDataProcessor
    {
        public IEnumerable JoinUsersToOrders(IEnumerable<User> users, IEnumerable<Order> orders);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using Module3FinalProject.Services.Abstractions;
using Module3FinalProject.Models;

namespace Module3FinalProject.Services
{
    public class DataProcessor : IDataProcessor
    {
        public IEnumerable JoinUsersToOrders(IEnumerable<User> users, IEnumerable<Order> orders)
        {
            return users.Where(u => u.Age > 18 && u.Age < 65)
                .Join(orders.Where(o => (DateTime.UtcNow - DateTime.Parse(o.OrderDate)).Days <= 7), u => u.Id, o => o.UserId, (u, o) => new { OrderNumber = o.OrderNumber, OrderDate = o.OrderDate, UserName = u.Name, Total = o.Total })
                .OrderBy(x => x.OrderDate).ToList();
        }
    }
}

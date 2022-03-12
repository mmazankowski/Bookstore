using System;
using System.Linq;
using Bookstore.Models;

namespace Bookstore.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }

        public void SaveOrder(Order order);
    }
}
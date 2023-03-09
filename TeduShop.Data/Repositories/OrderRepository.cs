using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
//using TeduShop.Common.ViewModels;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        //IEnumerable<RevenueStatisticViewModel> GetRevenueStatistic(string fromDate, string toDate);
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        
    }
}
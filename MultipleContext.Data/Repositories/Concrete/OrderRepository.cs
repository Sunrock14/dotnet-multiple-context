using Microsoft.EntityFrameworkCore;
using MultipleContext.Data.GenericRepositories;
using MultipleContext.Data.Models.ShoppingModels;
using MultipleContext.Data.Repositories.Abstract;

namespace MultipleContext.Data.Repositories.Concrete;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(DbContext context) : base(context)
    {
    }
}

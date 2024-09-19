using Microsoft.EntityFrameworkCore;
using MultipleContext.Data.GenericRepositories;
using MultipleContext.Data.Models.ShoppingModels;
using MultipleContext.Data.Repositories.Abstract;

namespace MultipleContext.Data.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(DbContext context) : base(context)
    {
    }
}

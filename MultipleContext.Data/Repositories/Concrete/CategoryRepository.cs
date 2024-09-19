using Microsoft.EntityFrameworkCore;
using MultipleContext.Data.Contexts;
using MultipleContext.Data.GenericRepositories;
using MultipleContext.Data.Models.ShoppingModels;
using MultipleContext.Data.Repositories.Abstract;

namespace MultipleContext.Data.Repositories.Concrete;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(DbContext context) : base(context)
    {
    }
}

using Microsoft.EntityFrameworkCore;
using MultipleContext.Data.GenericRepositories;
using MultipleContext.Data.Models.UserModels;
using MultipleContext.Data.Repositories.Abstract;

namespace MultipleContext.Data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}

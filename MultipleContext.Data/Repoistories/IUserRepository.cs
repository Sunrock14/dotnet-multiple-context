using MultipleContext.Data.GenericRepositories;
using MultipleContext.Data.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleContext.Data.Repoistories;

public interface IUserRepository : IGenericRepository<User>
{
}

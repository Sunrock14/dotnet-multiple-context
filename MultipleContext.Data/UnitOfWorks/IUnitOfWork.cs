using MultipleContext.Data.Repositories.Abstract;

namespace MultipleContext.Data.UnitOfWorks;

public interface IUnitOfWork : IAsyncDisposable
{
    IProductRepository Products {  get; }    
    IOrderRepository Orders { get; }
    IUserRepository Users { get; }
    
    ICategoryRepository Categories { get; }

    Task<int> SaveChangesAsync();
}

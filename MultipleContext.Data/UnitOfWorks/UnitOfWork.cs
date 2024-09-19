using MultipleContext.Data.Contexts;
using MultipleContext.Data.Repositories;
using MultipleContext.Data.Repositories.Abstract;
using MultipleContext.Data.Repositories.Concrete;

namespace MultipleContext.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UserContext _userContext;
        private readonly ShoppingContext _shoppingContext;

        public UnitOfWork(ShoppingContext shoppingContext, UserContext userContext)
        {
            _shoppingContext = shoppingContext;
            _userContext = userContext;
        }


        private OrderRepository _orderRepository;
        private ProductRepository _productRepository;
        private UserRepository _userRepository;
        private CategoryRepository _categoryRepository;

        public IProductRepository Products => _productRepository ??= new ProductRepository(_shoppingContext);

        public IOrderRepository Orders => _orderRepository ??= new OrderRepository(_shoppingContext);

        public IUserRepository Users => _userRepository ??= new UserRepository(_userContext);

        public ICategoryRepository Categories => _categoryRepository ??= new CategoryRepository(_shoppingContext);

        public async ValueTask DisposeAsync()
        {
            await _shoppingContext.DisposeAsync();
            await _userContext.DisposeAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            int shopping = await _shoppingContext.SaveChangesAsync();
            int user = await _userContext.SaveChangesAsync();
            return shopping+ user;
        }
    }
}

using MultipleContext.Data.GenericRepositories;

namespace MultipleContext.Data.Models.ShoppingModels;

public class ShoppingCart : IEntity
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public List<ShoppingCartItem> Items { get; set; }
}

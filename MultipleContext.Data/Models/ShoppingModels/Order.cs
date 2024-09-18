using MultipleContext.Data.GenericRepositories;

namespace MultipleContext.Data.Models.ShoppingModels;

public class Order : IEntity
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public string Status { get; set; }
    public List<OrderItem> OrderItems { get; set; }
}

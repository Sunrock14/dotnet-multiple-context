using Microsoft.EntityFrameworkCore;
using MultipleContext.Data.Models;
using MultipleContext.Data.Models.ShoppingModels;

namespace MultipleContext.Data.Contexts;

public class ShoppingContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    public ShoppingContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Ürün-Kategori ilişkisi
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId);

        // Sipariş-SiparişÖğesi ilişkisi
        modelBuilder.Entity<OrderItem>()
            .HasOne(oi => oi.Order)
            .WithMany(o => o.OrderItems)
            .HasForeignKey(oi => oi.OrderId);

        // SiparişÖğesi-Ürün ilişkisi
        modelBuilder.Entity<OrderItem>()
            .HasOne(oi => oi.Product)
            .WithMany()
            .HasForeignKey(oi => oi.ProductId);

        // AlışverişSepeti-AlışverişSepetiÖğesi ilişkisi
        modelBuilder.Entity<ShoppingCartItem>()
            .HasOne(sci => sci.ShoppingCart)
            .WithMany(sc => sc.Items)
            .HasForeignKey(sci => sci.ShoppingCartId);

        // AlışverişSepetiÖğesi-Ürün ilişkisi
        modelBuilder.Entity<ShoppingCartItem>()
            .HasOne(sci => sci.Product)
            .WithMany()
            .HasForeignKey(sci => sci.ProductId);
    }
}

using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
  public class ToDoListContext : DbContext
  {
    public DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<CategoryItemTag> CategoryItemTags { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}
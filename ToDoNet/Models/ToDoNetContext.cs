using Microsoft.EntityFrameworkCore;

namespace ToDoNet.Models
{
    public class ToDoNetContext : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;Port=8889;database=todonet;uid=root;pwd=root;");
    }
}

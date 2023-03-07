using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    //DataContext is used as a session to the database and can be used to query and save instances of entities

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        //DbSet is used for querying through Products table
        public DbSet<Product> Products { get; set; }
    }
}
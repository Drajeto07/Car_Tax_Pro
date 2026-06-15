using Microsoft.EntityFrameworkCore;
using Car.Models; 

public class AutoContext : DbContext
{
    public DbSet<Car.Models.Car> mps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=auto.db");
}
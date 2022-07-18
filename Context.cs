using Microsoft.EntityFrameworkCore;
using RealEstateMVC.Models;

public class Context : DbContext
{
    public Context() : base() { }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(@"Data Source=RealEstateMVC.db");
    }

    public DbSet<Property>?Properties {get;set;}
}
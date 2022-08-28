


using EntitiesClass.Entites;
using EntitiesClasses.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntitiesClasses.DataContext;
   public  class DataContexts : DbContext
{

    public DataContexts(DbContextOptions<DataContexts> options) : base(options)
    {
        this.ChangeTracker.LazyLoadingEnabled = false;
    }


    public DbSet<User> Users { get; set; }
    public DbSet<Brand> Brands { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
  

        base.OnModelCreating(modelBuilder);
    }



}


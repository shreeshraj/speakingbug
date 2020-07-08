using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CoreProject.Models
{
    public class LearningDbContext:DbContext
    {
    public DbSet<ContactEntity> contactEntities { get; set; }
    public DbSet<UserEntity> userEntities { get; set; }
    public DbSet<LoginEntity> loginEntities { get; set; }
    public DbSet<PostEntity> postEntities { get; set; }
    public DbSet<WordEntity> wordEntities { get; set; }
      

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        optionsBuilder.UseMySQL(configuration.GetConnectionString("DefaultConnection"));

    }
    }
}
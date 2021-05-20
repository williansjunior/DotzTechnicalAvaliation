using DotzAvaliacaoTecnica.Domain.Entities;
using DotzAvaliacaoTecnica.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace DotzAvaliacaoTecnica.Infra.Repository.Context
{
    public class DotzContext : DbContext
    {
        private readonly IConfiguration _config;
        public DotzContext(DbContextOptions<DotzContext> options, IConfiguration configuration) : base(options)
        {
            _config = configuration;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Points> Points { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<UserExtract> UserExtracts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // Define the database to use
        //    optionsBuilder.UseMySQL(_config.GetConnectionString("DotzConnection"));
            
        //}
    }
}

using CasgemMicroservices.Services.Order.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservices.Services.Order.Infrastructure.Persistance.Context
{
    public class OrderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=CasgemOrderDb;User=sa;Password=12345Aa*");
        }
        public DbSet<Addresss> Addressses { get; set; }
        public DbSet<Core.Domain.Entities.Ordering> orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}

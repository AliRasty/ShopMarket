using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopMarket.DataLayer.Entities.Account;

namespace ShopMarket.DataLayer.Context
{
    public class ApplicationDbContext :DbContext
    {

        public DbSet<User> Users { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var item in
                     modelBuilder.Model.GetEntityTypes()
                         .SelectMany(x=>x.GetForeignKeys()))
            {
                item.DeleteBehavior = DeleteBehavior.Cascade;

            }



            base.OnModelCreating(modelBuilder);
        }
    }
}

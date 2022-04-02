using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWork.Models;

namespace TestWork.Data
{
    public class DataBaaseContext : DbContext
    {
        public DbSet<User> Users{ get; set; }
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=PC-232-13\SQLEXPRESS;Initial Catalog=TestWork; User id=U-19K; Password=19K$YcYO");
        }
    }
}

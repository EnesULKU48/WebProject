using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entity.Concrete;

using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-M4FTRLA\\SQLEXPRESS;database=DbDemoOopCore;Trusted_Connection=True;TrustServerCertificate=True;integrated security=true;");
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Customer> Customers { get; set; }
	}
}

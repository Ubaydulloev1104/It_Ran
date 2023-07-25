using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{
			Database.EnsureCreated();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			var assembly = typeof(ApplicationDbContext).Assembly;
			modelBuilder.ApplyConfigurationsFromAssembly(assembly);
		}

		public DbSet<Laptops> Laptops { get; set; }
		public DbSet<Domain.Contact> Contact { get; set; }
	}
}

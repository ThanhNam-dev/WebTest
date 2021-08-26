using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
	public class WebTestDbContext : DbContext
	{
		public WebTestDbContext(DbContextOptions<WebTestDbContext> options) : base(options)
		{

		}
		public DbSet<Item> Items { get; set; }
	}
}

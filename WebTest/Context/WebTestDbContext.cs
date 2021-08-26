using WebTest.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebTest.Context
{
	public class WebTestDbContext : IdentityDbContext
	{
		public WebTestDbContext(DbContextOptions<WebTestDbContext> options) : base(options)
		{

		}
		public DbSet<Item> Items { get; set; }
	}
}

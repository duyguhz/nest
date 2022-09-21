using System;
using Microsoft.EntityFrameworkCore;
using nest.Models;

namespace nest.DAL
{
	public class NestContext:DbContext

	{
		public NestContext(DbContextOptions<NestContext> options):base(options)
		{

		}

		public DbSet<Product> Products { get; set; }
        public DbSet<Badge> Badges { get; set; }
    }
}


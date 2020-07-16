using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCar.Data.Context
{
	public class MeuDbContext : DbContext
	{
		public MeuDbContext(DbContextOptions options) : base(options)
		{

		}

		
	}
}

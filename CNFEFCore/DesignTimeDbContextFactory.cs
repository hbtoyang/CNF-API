using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CNFEFCore
{
    class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CNFDbContext>
	{
		public CNFDbContext CreateDbContext(string[] args)
		{
			DbContextOptionsBuilder<CNFDbContext> builder = new();
			//string connStr = Environment.GetEnvironmentVariable("ConnectionStrings:CNFEFCore");
			string connStr = "Server=.;Database=CNF;Trusted_Connection=True;MultipleActiveResultSets=true";
			builder.UseSqlServer(connStr);
			return new CNFDbContext(builder.Options);
		}
	}
}




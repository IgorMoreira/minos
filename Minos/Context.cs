using Minos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Minos
{
	public class Context : DbContext
	{
		public Context()
			: base(System.Configuration.ConfigurationManager.ConnectionStrings["DB"].ConnectionString)
		{
			Database.CreateIfNotExists();
		}

		public DbSet<Pessoa> Pessoas { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add<Pessoa>(new PessoaConfiguration());
			base.OnModelCreating(modelBuilder);
		}
	}
}
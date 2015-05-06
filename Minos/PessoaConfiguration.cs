using Minos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Minos
{
	public class PessoaConfiguration : EntityTypeConfiguration<Pessoa>
	{
		public PessoaConfiguration()
		{
			this.ToTable("Pessoa");

			this.Property(x => x.Id);
			this.Property(x => x.Nome);
			this.Property(x => x.Sexo);
			this.Property(x => x.Naturalidade);
			this.Property(x => x.CPF);
			this.Property(x => x.Altura);
			this.Property(x => x.Peso);
			this.Property(x => x.NivelDeEscolaridade);
			this.Property(x => x.DataDeNascimento).HasColumnType("Date");
			this.Property(x => x.Etnia);

			HasKey(x => x.Id);
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minos.Models
{
	public class Pessoa
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public DateTime DataDeNascimento { get; set; }
		public string CPF { get; set; }
		public string Naturalidade { get; set; }
		public decimal Altura { get; set; }
		public decimal Peso { get; set; }
		public string Etnia { get; set; }
		public string NivelDeEscolaridade { get; set; }
		public string Sexo { get; set; }
	}
}
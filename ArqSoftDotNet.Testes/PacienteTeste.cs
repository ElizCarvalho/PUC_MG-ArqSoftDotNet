using ArqSoftDotNet.Negocio;
using ArqSoftDotNet.TO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ArqSoftDotNet.Testes
{
	[TestClass]
	public class PacienteTeste
	{
		[TestMethod]
		public void NovoPaciente()
		{
			try
			{
				PacienteNegocio negPaciente = new PacienteNegocio();

				PacienteTO paciente = new PacienteTO();
				paciente.Nome = "João da Silva";
				paciente.NomeMae = "Maria da Silva";
				paciente.Nascimento = new DateTime(1987, 2, 8);
				paciente.Sexo = SexoEnum.Masculino;

				negPaciente.Adicionar(paciente);
			}
			catch (Exception ex)
			{
				Assert.Fail(ex.Message);
			}
		}
	}
}

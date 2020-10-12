using ArqSoftDotNet.Repositorio;
using ArqSoftDotNet.TO;
using System.Collections.Generic;

namespace ArqSoftDotNet.Negocio
{
	public class PacienteNegocio
	{
		public PacienteTO GetPacientePorId(int id)
		{
			PacienteRepositorio repPaciente = new PacienteRepositorio();
			return repPaciente.GetPacientePorId(id);
		}

		public List<PacienteTO> GetTodos()
		{
			PacienteRepositorio repPaciente = new PacienteRepositorio();
			return repPaciente.GetTodos();
		}

		public void Adicionar(PacienteTO paciente)
		{
			PacienteRepositorio repPaciente = new PacienteRepositorio();
			repPaciente.Novo(paciente);
		}

		public void Editar(PacienteTO paciente)
		{
			PacienteRepositorio repPaciente = new PacienteRepositorio();
			repPaciente.Atualiza(paciente);
		}
	}
}

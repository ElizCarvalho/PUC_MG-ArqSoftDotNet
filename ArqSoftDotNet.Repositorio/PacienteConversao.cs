using ArqSoftDotNet.Dados;
using ArqSoftDotNet.TO;

namespace ArqSoftDotNet.Repositorio
{
	internal static class PacienteConversao
	{
		//como o parametro de entrada tem this, entao esse metodo esta extendendo Paciente e vai estar disponivel nos objetos desse tipo
		internal static PacienteTO ToPacienteTO(this Paciente entity)
		{
			PacienteTO to = new PacienteTO();

			if (entity == null)
				return null;

			to.Id = entity.Id;
			to.Nome = entity.Nome;
			to.NomeMae = entity.NomeMae;
			to.Nascimento = entity.Nascimento;
			to.Sexo = (SexoEnum)entity.Sexo;

			return to;
		} 

		internal static void Apply(this Paciente entity, PacienteTO to)
		{
			entity.Nome = to.Nome;
			entity.NomeMae = to.NomeMae;
			entity.Nascimento = to.Nascimento;
			entity.Sexo = (int)to.Sexo;
		}
	}
}

using ArqSoftDotNet.Dados;

namespace ArqSoftDotNet.Repositorio
{
	public class RepositorioBase
	{
		public ArqSoftDotNetEntities Contexto
		{
			get { return _Contexto; }
			set{ _Contexto = value; }
		}

		private ArqSoftDotNetEntities _Contexto;

		public RepositorioBase()
		{
			_Contexto = new ArqSoftDotNetEntities();
		}
	}
}

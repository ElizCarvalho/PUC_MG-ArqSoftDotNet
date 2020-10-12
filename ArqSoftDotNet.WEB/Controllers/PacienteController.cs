using System.Web.Mvc;

namespace ArqSoftDotNet.WEB.Controllers
{
	public class PacienteController : Controller
	{
		// GET: Paciente
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult ListaPacientes()
		{
			ServicoExposto.ServicoSoapClient servico = new ServicoExposto.ServicoSoapClient();
			var lista = servico.GetPacientes();
			return View(lista);
		}
	}
}
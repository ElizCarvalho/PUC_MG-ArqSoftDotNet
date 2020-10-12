namespace ArqSoftDotNet.TO
{
	public class AtendimentoTO
	{
		public PacienteTO Paciente { get; set; }
		public int Id { get; set; }
		public string Anamnese { get; set; }
		public string ExameFisico { get; set; }
		public string CIDPrincipal { get; set; }
	}
}

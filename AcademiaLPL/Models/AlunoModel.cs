namespace AcademiaLPL.Models
{
    public class AlunoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataMatricula { get; set; }
        public int Ativo { get; set; }
    }
}

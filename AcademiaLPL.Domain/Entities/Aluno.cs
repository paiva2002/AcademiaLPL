using AcademiaLPL.Domain.Base;

namespace AcademiaLPL.Domain.Entities
{
    public class Aluno : BaseEntity<int>
    {
        public Aluno()
        {

        }

        public Aluno(int id, string nome, DateTime datanascimento, string telefone, string email,
            DateTime datamatricula, int ativo) : base(id)
        {
            Nome = nome;
            DataNascimento = datanascimento;
            Telefone = telefone;
            Email = email;
            DataMatricula = datamatricula;

        }

        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataMatricula { get; set; }
    }
}

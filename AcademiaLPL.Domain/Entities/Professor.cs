using AcademiaLPL.Domain.Base;

namespace AcademiaLPL.Domain.Entities
{
    public class Professor : BaseEntity<int>
    {
        public Professor()
        {
        }
        public Professor(int id, string nome, string telefone,
            string email, string especialidade, int ativo)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Especialidade = especialidade;
            Ativo = ativo;
            
        }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? Especialidade { get; set; }
        public int? Ativo { get; set; }
    }
}

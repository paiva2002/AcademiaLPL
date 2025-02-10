using AcademiaLPL.Domain.Base;

namespace AcademiaLPL.Domain.Entities
{
    public class Modalidade : BaseEntity<int>
    {
        public Modalidade()
        {
        }

        public Modalidade(int id, string nome, string descricao, double precomensal)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Precomensal = precomensal; 
        }

        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public double? Precomensal { get; set; }
    }
}

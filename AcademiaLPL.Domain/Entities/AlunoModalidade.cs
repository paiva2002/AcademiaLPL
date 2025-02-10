using AcademiaLPL.Domain.Base;
using System.Text.Json.Serialization;

namespace AcademiaLPL.Domain.Entities
{
    public class AlunoModalidade : BaseEntity<int>
    {
        public AlunoModalidade()
        {
        }

        public AlunoModalidade(int idaluno, int idmodalidade, DateTime datainicio, int ativo, Aluno? aluno,
            Modalidade? modalidade) : base(idaluno)
        {
            IdAluno = idaluno;
            IdModalidade = idmodalidade;
            DataInicio = datainicio;
            Modalidade = modalidade;
            Aluno = aluno;
            
        }

        public DateTime DataInicio { get; set; }
        public int IdAluno { get; set; }
        public int IdModalidade { get; set; }
        public virtual Modalidade? Modalidade { get; set; }
        public virtual Aluno? Aluno { get; set; }
    }

   
}

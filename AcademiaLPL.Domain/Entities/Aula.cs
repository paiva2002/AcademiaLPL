using AcademiaLPL.Domain.Base;
using AcademiaLPL.Domain.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace AcademiaLPL.Domain.Entities
{
    public class Aula : BaseEntity<int>
    {
        public Aula()
        {

        }

        public Aula(int id, int idmodalidade, int idprofessor, string diasemana, DateTime horarioinicio,
            DateTime horariofim, Modalidade? modalidade, Professor? professor) : base(id)
        {
            IdModalidade = idmodalidade;
            IdProfessor = idprofessor;
            DiaSemana = diasemana;
            HorarioInicio = horarioinicio;
            HorarioFim = horariofim;
            Modalidade = modalidade;
            Professor = professor;
        }

        public int IdModalidade { get; set; }
        public int IdProfessor { get; set; }
        public string DiaSemana { get; set; }
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFim { get; set; }
        public Modalidade? Modalidade { get; set; }
        public Professor? Professor { get; set; }

    }
}

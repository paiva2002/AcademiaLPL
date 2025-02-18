using AcademiaLPL.Base;
using AcademiaLPL.Domain.Base;
using AcademiaLPL.Domain.Entities;
using AcademiaLPL.Service.Validators;

namespace AcademiaLPL.Cadastros
{
    public partial class CadastroAula : CadastroBase
    {
        private readonly IBaseService<Aula> _aulaService;
        private readonly IBaseService<Professor> _professorService;
        private readonly IBaseService<Modalidade> _modalidadeService;

        private List<Aula>? aulas;
        private List<Professor>? professores;
        private List<Modalidade>? modalidades;

        public CadastroAula(IBaseService<Aula> aulaService, IBaseService<Professor> professorService, IBaseService<Modalidade> modalidadeService)
        {
            _aulaService = aulaService;
            _professorService = professorService;
            _modalidadeService = modalidadeService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
          
            modalidades = _modalidadeService.Get<Modalidade>().ToList();
            cboIdModalidade.DataSource = modalidades;
            cboIdModalidade.DisplayMember = "Nome";
            cboIdModalidade.ValueMember = "Id";

          
            professores = _professorService.Get<Professor>().ToList();
            cboIdProfessor.DataSource = professores;
            cboIdProfessor.DisplayMember = "Nome";
            cboIdProfessor.ValueMember = "Id";
        }

        private void PreencheObjeto(Aula aula)
        {
            if (cboIdModalidade.SelectedValue != null)
            {
                int idModalidade = Convert.ToInt32(cboIdModalidade.SelectedValue);
                aula.Modalidade = modalidades.FirstOrDefault(m => m.Id == idModalidade);
            }

            if (cboIdProfessor.SelectedValue != null)
            {
                int idProfessor = Convert.ToInt32(cboIdProfessor.SelectedValue);
                aula.Professor = professores.FirstOrDefault(p => p.Id == idProfessor);
            }

            aula.DiaSemana = textDiaAula.Text;

            if (DateTime.TryParse(textHoraInicio.Text, out var horaInicio))
            {
                aula.HorarioInicio = horaInicio;
            }

            if (DateTime.TryParse(textHoraFim.Text, out var horaFim))
            {
                aula.HorarioFim = horaFim;
            }
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao && int.TryParse(textId.Text, out var id))
                {
                    var aula = _aulaService.GetById<Aula>(id);
                    PreencheObjeto(aula);
                    _aulaService.Update<Aula, Aula, AulaValidator>(aula);
                }
                else
                {
                    var aula = new Aula();
                    PreencheObjeto(aula);
                    _aulaService.Add<Aula, Aula, AulaValidator>(aula);
                }

                CarregaGrid();
                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _aulaService.Delete(id);
                CarregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            aulas = _aulaService.Get<Aula>().ToList();

            var aulasFormatadas = aulas.Select(a => new
            {
                Id = a.Id,
                IdModalidade = a.Modalidade?.Id ?? 0,
                Modalidade = a.Modalidade?.Nome ?? "Desconhecida",
                IdProfessor = a.Professor?.Id ?? 0,
                Professor = a.Professor?.Nome ?? "Desconhecido",
                DiaSemana = a.DiaSemana,
                HorarioInicio = a.HorarioInicio.ToString("HH:mm"),
                HorarioFim = a.HorarioFim.ToString("HH:mm")
            }).ToList();

            dataGridViewConsulta.DataSource = aulasFormatadas;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            if (linha != null)
            {
                textId.Text = linha.Cells["Id"].Value?.ToString();
                cboIdModalidade.SelectedValue = linha.Cells["IdModalidade"].Value;
                cboIdProfessor.SelectedValue = linha.Cells["IdProfessor"].Value;
                textDiaAula.Text = linha.Cells["DiaSemana"].Value?.ToString();
                textHoraInicio.Text = linha.Cells["HorarioInicio"].Value?.ToString();
                textHoraFim.Text = linha.Cells["HorarioFim"].Value?.ToString();
            }
        }
    }
}

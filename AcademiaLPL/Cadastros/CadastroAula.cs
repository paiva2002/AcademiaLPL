using AcademiaLPL.Base;
using AcademiaLPL.Domain.Base;
using AcademiaLPL.Domain.Entities;
using AcademiaLPL.Models;
using AcademiaLPL.Service.Validators;


namespace AcademiaLPL.Cadastros
{
    public partial class CadastroAula : CadastroBase
    {
        private readonly IBaseService<Aula> _aulaService;
        private readonly IBaseService<Professor> _professorService;
        private readonly IBaseService<Modalidade> _modalidadeService;

        private List<AulaModel>? aulas;
        private List<ProfessorModel>? professors;
        private List<ModalidadeModel>? modalidades;

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
            cboIdModalidade.ValueMember = "Id";
            cboIdProfessor.DisplayMember = "Id";
            cboIdModalidade.DataSource = _modalidadeService.Get<ModalidadeModel>().ToList();
            cboIdProfessor.DataSource = _professorService.Get<ProfessorModel>().ToList();
        }

        private void PreencheObjeto(Aula aula)
        {
            if (int.TryParse(cboIdModalidade.SelectedValue.ToString(), out int idModalidade))
            {
                var modalidade = _modalidadeService.GetById<Modalidade>(idModalidade);
                aula.Modalidade = modalidade;
            }
            if (int.TryParse(cboIdProfessor.SelectedValue.ToString(), out int idProfessor))
            {
                var professor = _modalidadeService.GetById<Professor>(idProfessor);
                aula.Professor = professor;
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
                if (IsAlteracao)
                {
                    if (int.TryParse(textId.Text, out var id))
                    {
                        var aula = _aulaService.GetById<Aula>(id);
                        PreencheObjeto(aula);
                        aula = _aulaService.Update<Aula, Aula, AulaValidator>(aula);
                    }
                }
                else
                {
                    var aula = new Aula();
                    PreencheObjeto(aula);
                    _aulaService.Add<Aula, Aula, AulaValidator>(aula);

                }

                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _aulaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            aulas = _aulaService.Get<AulaModel>(false, new[] { "Aula" }).ToList();
            dataGridViewConsulta.DataSource = aulas;
            dataGridViewConsulta.Columns["IdAula"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            textId.Text = linha?.Cells["Id"].Value.ToString();
            cboIdModalidade.SelectedValue = linha?.Cells["IdModalidade"].Value;
            cboIdProfessor.SelectedValue = linha?.Cells["IdProfessor"].Value;
            textDiaAula.Text = linha?.Cells["DiaAula"].Value.ToString();
            textHoraInicio.Text = DateTime.TryParse(linha?.Cells["HorarioInicio"].Value.ToString(), out var horaI)
               ? horaI.ToString("g")
               : "";
            textHoraFim.Text = DateTime.TryParse(linha?.Cells["HorarioInicio"].Value.ToString(), out var horaF)
               ? horaF.ToString("g")
               : "";
        }

    }
}

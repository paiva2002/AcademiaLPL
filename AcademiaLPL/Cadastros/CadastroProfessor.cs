using AcademiaLPL.Base;
using AcademiaLPL.Domain.Base;
using AcademiaLPL.Domain.Entities;
using AcademiaLPL.Models;
using AcademiaLPL.Service.Validators;


namespace AcademiaLPL.Cadastros
{
    public partial class CadastroProfessor : CadastroBase
    {
        private readonly IBaseService<Professor> _professorService;
       

        private List<ProfessorModel>? professors;

        public CadastroProfessor(IBaseService<Professor> professorService)
        {
            _professorService = professorService;
            InitializeComponent();
        }

        private void PreencheObjeto(Professor professor)
        {
            professor.Nome = textNome.Text;
            professor.Telefone = txtTelefone.Text;
            professor.Especialidade = textEspecialidade.Text;
            professor.Email = textEmail.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(textId.Text, out var id))
                    {
                        var professor = _professorService.GetById<Professor>(id);
                        PreencheObjeto(professor);
                        professor = _professorService.Update<Professor, Professor, ProfessorValidator>(professor);
                    }
                }
                else
                {
                    var professor = new Professor();
                    PreencheObjeto(professor);
                    _professorService.Add<Professor, Professor, ProfessorValidator>(professor);

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
                _professorService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            professors = _professorService.Get<ProfessorModel>(false, new[] { "Professor" }).ToList();
            dataGridViewConsulta.DataSource = professors;
            dataGridViewConsulta.Columns["IdProfessor"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            textId.Text = linha?.Cells["Id"].Value.ToString();
            textNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            textEspecialidade.Text = linha?.Cells["EspecialidadeProfessor"].Value.ToString();
            textEmail.Text = linha?.Cells["Email"].Value.ToString();
        }

    }

}

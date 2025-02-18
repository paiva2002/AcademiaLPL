using AcademiaLPL.Base;
using AcademiaLPL.Domain.Base;
using AcademiaLPL.Domain.Entities;
using AcademiaLPL.Service.Validators;

namespace AcademiaLPL.Cadastros
{
    public partial class CadastroProfessor : CadastroBase
    {
        private readonly IBaseService<Professor> _professorService;
        private List<Professor>? professors;

        public CadastroProfessor(IBaseService<Professor> professorService)
        {
            _professorService = professorService;
            InitializeComponent();
        }

        private Professor CriarProfessor()
        {
            return new Professor
            {
                Nome = textNome.Text,
                Telefone = txtTelefone.Text,
                Especialidade = textEspecialidade.Text,
                Email = textEmail.Text
            };
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
                        if (professor == null)
                        {
                            MessageBox.Show("Professor não encontrado!", @"Cadastro de Professores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        var novoProfessor = CriarProfessor();
                        professor.Nome = novoProfessor.Nome;
                        professor.Telefone = novoProfessor.Telefone;
                        professor.Especialidade = novoProfessor.Especialidade;
                        professor.Email = novoProfessor.Email;

                        _professorService.Update<Professor, Professor, ProfessorValidator>(professor);
                    }
                }
                else
                {
                    var professor = CriarProfessor();
                    _professorService.Add<Professor, Professor, ProfessorValidator>(professor);

                    var professorCadastrado = _professorService
                        .Get<Professor>()
                        .OrderByDescending(p => p.Id) 
                        .FirstOrDefault(p => p.Email == professor.Email && p.Nome == professor.Nome);

                    if (professorCadastrado != null)
                    {
                        professor.Id = professorCadastrado.Id;
                    }
                }

                CarregaGrid(); 
                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Cadastro de Professores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                var professor = _professorService.GetById<Professor>(id);
                if (professor == null)
                {
                    MessageBox.Show("Professor não encontrado!", @"Cadastro de Professores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _professorService.Delete(id);
                CarregaGrid(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Cadastro de Professores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            professors = _professorService.Get<Professor>().ToList();

            foreach (var professor in professors)
            {
                Console.WriteLine($"Professor: {professor.Nome}, ID: {professor.Id}");
            }

            dataGridViewConsulta.DataSource = professors;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            if (linha == null) return;

            textId.Text = linha.Cells["Id"].Value?.ToString();
            textNome.Text = linha.Cells["Nome"].Value?.ToString();
            txtTelefone.Text = linha.Cells["Telefone"].Value?.ToString();
            textEspecialidade.Text = linha.Cells["Especialidade"].Value?.ToString();
            textEmail.Text = linha.Cells["Email"].Value?.ToString();
        }
    }
}

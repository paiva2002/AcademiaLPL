using AcademiaLPL.Base;
using AcademiaLPL.Domain.Base;
using AcademiaLPL.Domain.Entities;
using AcademiaLPL.Service.Validators;


namespace AcademiaLPL.Cadastros
{
    public partial class CadastroAluno : CadastroBase
    {
        private IBaseService<Aluno> _alunoService;
        private List<Aluno> alunos;
        public CadastroAluno(IBaseService<Aluno> alunoService)
        {
            _alunoService = alunoService;
            InitializeComponent();
        }

        private void PreencheObjeto(Aluno aluno)
        {
            aluno.Nome = textNome.Text;
            if (DateTime.TryParse(textDataNascimento.Text, out var dataNascimento))
            {
                aluno.DataNascimento = dataNascimento;
            }
            if (DateTime.TryParse(textDataMatricula.Text, out var dataMatricula))
            {
                aluno.DataMatricula = dataMatricula;
            }
            aluno.Email = textEmail.Text;
            aluno.Telefone = textTelefone.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(textId.Text, out var id))
                    {
                        var aluno = _alunoService.GetById<Aluno>(id);
                        PreencheObjeto(aluno);
                        aluno = _alunoService.Update<Aluno, Aluno, AlunoValidator>(aluno);
                    }
                }
                else
                {
                    var aluno = new Aluno();
                    PreencheObjeto(aluno);
                    _alunoService.Add<Aluno, Aluno, AlunoValidator>(aluno);

                }
                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _alunoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            alunos = _alunoService.Get<Aluno>().ToList();
            dataGridViewConsulta.DataSource = alunos;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
           
            textId.Text = linha?.Cells["Id"].Value.ToString();
            textNome.Text = linha?.Cells["Nome"].Value.ToString();
            textDataNascimento.Text = linha?.Cells["DataNascimento"].Value.ToString();
            textDataMatricula.Text = linha?.Cells["DataMatricula"].Value.ToString();
            textEmail.Text = linha?.Cells["Email"].Value.ToString();
            textTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
        }
    }
}

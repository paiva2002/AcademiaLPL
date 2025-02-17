using AcademiaLPL.Base;
using AcademiaLPL.Domain.Base;
using AcademiaLPL.Domain.Entities;
using AcademiaLPL.Models;
using AcademiaLPL.Service.Validators;

namespace AcademiaLPL.Cadastros
{
    public partial class CadastroAlunoModalidade : CadastroBase
    {
        private readonly IBaseService<AlunoModalidade> _alunoModalidadeService;
        private readonly IBaseService<Aluno> _alunoService;
        private List<AlunoModalidadeModel>? alunoModalidades;
        private List<AlunoModel>? alunos;

        public CadastroAlunoModalidade(IBaseService<AlunoModalidade> alunoModalidadeService, IBaseService<Aluno> alunoService)
        {
            _alunoModalidadeService = alunoModalidadeService;
            _alunoService = alunoService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboIdAluno.ValueMember = "Id";
            cboIdAluno.DisplayMember = "Nome"; // Exibe o nome do aluno
            cboIdAluno.DataSource = _alunoService.Get<AlunoModel>().ToList();

            cboIdModalidade.ValueMember = "Id";
            cboIdModalidade.DisplayMember = "NomeModalidade"; // Exibe o nome da modalidade
            cboIdModalidade.DataSource = _alunoModalidadeService.Get<AlunoModalidadeModel>().ToList();
        }

        private AlunoModalidade CriarAlunoModalidade()
        {
            var alunoModalidade = new AlunoModalidade();

            if (cboIdAluno.SelectedValue is int idAluno)
            {
                alunoModalidade.IdAluno = idAluno;
            }

            if (cboIdModalidade.SelectedValue is int idModalidade)
            {
                alunoModalidade.IdModalidade = idModalidade;
            }

            if (DateTime.TryParse(textDataInicio.Text, out var dataInicio))
            {
                alunoModalidade.DataInicio = dataInicio;
            }

            return alunoModalidade;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(cboIdAluno.Text, out var id))
                    {
                        var alunoModalidade = _alunoModalidadeService.GetById<AlunoModalidade>(id);
                        if (alunoModalidade == null)
                        {
                            MessageBox.Show("Aluno Modalidade não encontrado!",
                                            "Cadastro",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        var novaAlunoModalidade = CriarAlunoModalidade();
                        alunoModalidade.IdAluno = novaAlunoModalidade.IdAluno;
                        alunoModalidade.IdModalidade = novaAlunoModalidade.IdModalidade;
                        alunoModalidade.DataInicio = novaAlunoModalidade.DataInicio;

                        _alunoModalidadeService.Update<AlunoModalidade, AlunoModalidade, AlunoModalidadeValidator>(alunoModalidade);
                    }
                }
                else
                {
                    var alunoModalidade = CriarAlunoModalidade();
                    _alunoModalidadeService.Add<AlunoModalidade, AlunoModalidade, AlunoModalidadeValidator>(alunoModalidade);
                }

                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                var alunoModalidade = _alunoModalidadeService.GetById<AlunoModalidade>(id);
                if (alunoModalidade == null)
                {
                    MessageBox.Show("Aluno Modalidade não encontrado!",
                                    "Cadastro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _alunoModalidadeService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            alunoModalidades = _alunoModalidadeService.Get<AlunoModalidadeModel>(false, new[] { "Aluno", "Modalidade" }).ToList();
            dataGridViewConsulta.DataSource = alunoModalidades;

            if (dataGridViewConsulta.Columns.Contains("IdModalidade"))
                dataGridViewConsulta.Columns["IdModalidade"].Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            if (linha == null) return;

            cboIdAluno.SelectedValue = linha.Cells["IdAluno"]?.Value;
            cboIdModalidade.SelectedValue = linha.Cells["IdModalidade"]?.Value;

            textDataInicio.Text = DateTime.TryParse(linha.Cells["DataInicio"]?.Value?.ToString(), out var dataInicio)
                ? dataInicio.ToString("dd/MM/yyyy")
                : "";
        }
    }
}

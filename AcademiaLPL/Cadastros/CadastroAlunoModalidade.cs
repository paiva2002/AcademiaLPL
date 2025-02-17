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
        private readonly IBaseService<Modalidade> _modalidadeService;
        private List<AlunoModalidadeModel>? alunoModalidades;
        private List<AlunoModel>? alunos;
        private List<Modalidade>? modalidades;

        public CadastroAlunoModalidade(
            IBaseService<AlunoModalidade> alunoModalidadeService,
            IBaseService<Aluno> alunoService,
            IBaseService<Modalidade> modalidadeService) // Adicionado o serviço de Modalidade
        {
            _alunoModalidadeService = alunoModalidadeService;
            _alunoService = alunoService;
            _modalidadeService = modalidadeService; // Inicializa o serviço de modalidades
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            try
            {
                // Carregar alunos
                cboIdAluno.ValueMember = "Id";
                cboIdAluno.DisplayMember = "Nome";
                cboIdAluno.DataSource = _alunoService.Get<AlunoModel>().ToList();

                // Carregar modalidades corretamente
                modalidades = _modalidadeService.Get<Modalidade>().ToList();

                if (modalidades.Count == 0)
                {
                    MessageBox.Show("Nenhuma modalidade cadastrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cboIdModalidade.ValueMember = "Id";
                cboIdModalidade.DisplayMember = "Nome"; // Corrigido para acessar o nome correto
                cboIdModalidade.DataSource = modalidades;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private AlunoModalidade CriarAlunoModalidade()
        {
            var alunoModalidade = new AlunoModalidade();

            if (cboIdAluno.SelectedValue is int idAluno)
            {
                alunoModalidade.IdAluno = idAluno;
            }
            else
            {
                MessageBox.Show("Selecione um aluno válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (cboIdModalidade.SelectedValue is int idModalidade)
            {
                alunoModalidade.IdModalidade = idModalidade;
            }
            else
            {
                MessageBox.Show("Selecione uma modalidade válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (DateTime.TryParse(textDataInicio.Text, out var dataInicio))
            {
                alunoModalidade.DataInicio = dataInicio;
            }
            else
            {
                MessageBox.Show("Data de início inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return alunoModalidade;
        }

        protected override void Salvar()
        {
            try
            {
                var alunoModalidade = CriarAlunoModalidade();
                if (alunoModalidade == null) return;

                if (IsAlteracao)
                {
                    if (int.TryParse(cboIdAluno.Text, out var id))
                    {
                        var alunoModalidadeExistente = _alunoModalidadeService.GetById<AlunoModalidade>(id);
                        if (alunoModalidadeExistente == null)
                        {
                            MessageBox.Show("Aluno Modalidade não encontrado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        alunoModalidadeExistente.IdAluno = alunoModalidade.IdAluno;
                        alunoModalidadeExistente.IdModalidade = alunoModalidade.IdModalidade;
                        alunoModalidadeExistente.DataInicio = alunoModalidade.DataInicio;

                        _alunoModalidadeService.Update<AlunoModalidade, AlunoModalidade, AlunoModalidadeValidator>(alunoModalidadeExistente);
                    }
                }
                else
                {
                    _alunoModalidadeService.Add<AlunoModalidade, AlunoModalidade, AlunoModalidadeValidator>(alunoModalidade);
                }

                MessageBox.Show("Cadastro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                var alunoModalidade = _alunoModalidadeService.GetById<AlunoModalidade>(id);
                if (alunoModalidade == null)
                {
                    MessageBox.Show("Aluno Modalidade não encontrado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _alunoModalidadeService.Delete(id);
                MessageBox.Show("Cadastro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            try
            {
                alunoModalidades = _alunoModalidadeService.Get<AlunoModalidadeModel>(false, new[] { "Aluno", "Modalidade" }).ToList();
                dataGridViewConsulta.DataSource = alunoModalidades;

                if (dataGridViewConsulta.Columns.Contains("IdModalidade"))
                    dataGridViewConsulta.Columns["IdModalidade"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar grid: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

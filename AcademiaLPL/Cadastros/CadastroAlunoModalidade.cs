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
            cboIdModalidade.DisplayMember = "IdModalidade";
            cboIdAluno.DataSource = _alunoService.Get<AlunoModel>().ToList();
            cboIdModalidade.DataSource = _alunoModalidadeService.Get<AlunoModalidadeModel>().ToList();
        }

        private void PreencheObjeto(AlunoModalidade alunoModalidade)
        {
            if (int.TryParse(cboIdAluno.SelectedValue.ToString(), out int idAluno))
            {
                var aluno = _alunoService.GetById<Aluno>(idAluno);
                alunoModalidade.Aluno = aluno;
            }
            if (int.TryParse(cboIdModalidade.SelectedValue.ToString(), out int idModalidade))
            {
                var modalidade = _alunoService.GetById<AlunoModalidade>(idModalidade);
                alunoModalidade.IdModalidade = idModalidade;
            }
            if (DateTime.TryParse(textDataInicio.Text, out var dataInicio))
            {
                alunoModalidade.DataInicio = dataInicio;
            }
           
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
                        PreencheObjeto(alunoModalidade);
                        alunoModalidade = _alunoModalidadeService.Update<AlunoModalidade, AlunoModalidade, AlunoModalidadeValidator>(alunoModalidade);
                    }
                }
                else
                {
                    var alunoModalidade = new AlunoModalidade();
                    PreencheObjeto(alunoModalidade);
                    _alunoModalidadeService.Add<AlunoModalidade, AlunoModalidade, AlunoModalidadeValidator>(alunoModalidade);

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
                _alunoModalidadeService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            alunoModalidades = _alunoModalidadeService.Get<AlunoModalidadeModel>(false, new[] { "Aluno Modalidade" }).ToList();
            dataGridViewConsulta.DataSource = alunoModalidades;
            dataGridViewConsulta.Columns["IdModalidade"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            cboIdAluno.SelectedValue = linha?.Cells["IdAluno"].Value;
            cboIdModalidade.SelectedValue = linha?.Cells["IdModalidade"].Value;
            textDataInicio.Text = DateTime.TryParse(linha?.Cells["DataInicio"].Value.ToString(), out var dataC)
               ? dataC.ToString("g")
               : "";

        }

    }
}

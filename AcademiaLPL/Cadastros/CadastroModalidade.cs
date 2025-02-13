using AcademiaLPL.Base;
using AcademiaLPL.Domain.Base;
using AcademiaLPL.Domain.Entities;
using AcademiaLPL.Models;
using AcademiaLPL.Service.Validators;

namespace AcademiaLPL.Cadastros
{
    public partial class CadastroModalidade : CadastroBase
    {
        private readonly IBaseService<Modalidade> _modalidadeService;
       

        private List<ModalidadeModel>? modalidades;

        public CadastroModalidade(IBaseService<Modalidade> modalidadeService)
        {
            _modalidadeService = modalidadeService;
            InitializeComponent();
        }
        private void PreencheObjeto(Modalidade modalidade)
        {
            modalidade.Nome = textNome.Text;
            modalidade.Descricao = textDescricao.Text;
            if (double.TryParse(textPreco.Text, out double precoMensal))
            {
                modalidade.Precomensal = precoMensal;
            }
            else
            {
                MessageBox.Show("O valor do preço mensal é inválido. Digite um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        var modalidade = _modalidadeService.GetById<Modalidade>(id);
                        PreencheObjeto(modalidade);
                        modalidade = _modalidadeService.Update<Modalidade, Modalidade, ModalidadeValidator>(modalidade);
                    }
                }
                else
                {
                    var modalidade = new Modalidade();
                    PreencheObjeto(modalidade);
                    _modalidadeService.Add<Modalidade, Modalidade, ModalidadeValidator>(modalidade);

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
                _modalidadeService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            modalidades = _modalidadeService.Get<ModalidadeModel>(false, new[] { "Modalidade" }).ToList();
            dataGridViewConsulta.DataSource = modalidades;
            dataGridViewConsulta.Columns["IdModalidade"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            textId.Text = linha?.Cells["Id"].Value.ToString();
            textNome.Text = linha?.Cells["NomeModalidade"].Value.ToString();
            textDescricao.Text = linha?.Cells["DescricaoModalidade"].Value.ToString();
            textPreco.Text = double.TryParse(linha?.Cells["PrecoMensal"].Value?.ToString(), out double preco)
            ? preco.ToString("F2")
            : "";
        }

    }
}

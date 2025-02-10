using AcademiaLPL.Cadastros;
//using AcademiaLPL.Infra;
//using AcademiaLPL.Outros;
using AcademiaLPL.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using IFSPStore.App.Infra;

namespace AcademiaLPL
{
    public partial class FormPrincipal : MaterialForm
    {
        //public static Usuario Usuario { get; set; }
        public FormPrincipal()
        {
            InitializeComponent();
            //CarregaLogin();
        }

        /* private void CarregaLogin()
         {
             var login = ConfigureDI.ServicesProvider!.GetService<Login>();
             if (login != null && !login.IsDisposed)
             {
                 if (login.ShowDialog() != DialogResult.OK)
                 {
                     Environment.Exit(0);
                 }
                 else
                 {
                     lblUsuario.Text = $"Usuário: {Usuario.Nome}";
                 }
             }
         }*/

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }

        private void modalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroModalidade>();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroProfessor>();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroAluno>();
        }

        private void aulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroAula>();
        }

        private void alunoModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroAlunoModalidade>();
        }

  

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }
    }
}

namespace AcademiaLPL.Cadastros
{
    partial class CadastroAlunoModalidade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textDataInicio = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            textAtivo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboIdAluno = new ReaLTaiizor.Controls.MaterialComboBox();
            cboIdModalidade = new ReaLTaiizor.Controls.MaterialComboBox();
            tabControlBase.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cboIdModalidade);
            tabPage1.Controls.Add(cboIdAluno);
            tabPage1.Controls.Add(textAtivo);
            tabPage1.Controls.Add(textDataInicio);
            tabPage1.Controls.SetChildIndex(textDataInicio, 0);
            tabPage1.Controls.SetChildIndex(textAtivo, 0);
            tabPage1.Controls.SetChildIndex(cboIdAluno, 0);
            tabPage1.Controls.SetChildIndex(cboIdModalidade, 0);
            // 
            // textDataInicio
            // 
            textDataInicio.AnimateReadOnly = false;
            textDataInicio.AutoCompleteMode = AutoCompleteMode.None;
            textDataInicio.AutoCompleteSource = AutoCompleteSource.None;
            textDataInicio.BackgroundImageLayout = ImageLayout.None;
            textDataInicio.CharacterCasing = CharacterCasing.Normal;
            textDataInicio.Depth = 0;
            textDataInicio.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textDataInicio.HideSelection = true;
            textDataInicio.Hint = "Data De Inicio Na Modalidade ";
            textDataInicio.LeadingIcon = null;
            textDataInicio.Location = new Point(6, 84);
            textDataInicio.MaxLength = 32767;
            textDataInicio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textDataInicio.Name = "textDataInicio";
            textDataInicio.PasswordChar = '\0';
            textDataInicio.PrefixSuffixText = null;
            textDataInicio.ReadOnly = false;
            textDataInicio.RightToLeft = RightToLeft.No;
            textDataInicio.SelectedText = "";
            textDataInicio.SelectionLength = 0;
            textDataInicio.SelectionStart = 0;
            textDataInicio.ShortcutsEnabled = true;
            textDataInicio.Size = new Size(512, 48);
            textDataInicio.TabIndex = 2;
            textDataInicio.TabStop = false;
            textDataInicio.TextAlign = HorizontalAlignment.Left;
            textDataInicio.TrailingIcon = null;
            textDataInicio.UseSystemPasswordChar = false;
            // 
            // textAtivo
            // 
            textAtivo.AnimateReadOnly = false;
            textAtivo.AutoCompleteMode = AutoCompleteMode.None;
            textAtivo.AutoCompleteSource = AutoCompleteSource.None;
            textAtivo.BackgroundImageLayout = ImageLayout.None;
            textAtivo.CharacterCasing = CharacterCasing.Normal;
            textAtivo.Depth = 0;
            textAtivo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textAtivo.HideSelection = true;
            textAtivo.Hint = "Ativo";
            textAtivo.LeadingIcon = null;
            textAtivo.Location = new Point(524, 84);
            textAtivo.MaxLength = 32767;
            textAtivo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textAtivo.Name = "textAtivo";
            textAtivo.PasswordChar = '\0';
            textAtivo.PrefixSuffixText = null;
            textAtivo.ReadOnly = true;
            textAtivo.RightToLeft = RightToLeft.No;
            textAtivo.SelectedText = "";
            textAtivo.SelectionLength = 0;
            textAtivo.SelectionStart = 0;
            textAtivo.ShortcutsEnabled = true;
            textAtivo.Size = new Size(250, 48);
            textAtivo.TabIndex = 3;
            textAtivo.TabStop = false;
            textAtivo.TextAlign = HorizontalAlignment.Left;
            textAtivo.TrailingIcon = null;
            textAtivo.UseSystemPasswordChar = false;
            // 
            // cboIdAluno
            // 
            cboIdAluno.AutoResize = false;
            cboIdAluno.BackColor = Color.FromArgb(255, 255, 255);
            cboIdAluno.Depth = 0;
            cboIdAluno.DrawMode = DrawMode.OwnerDrawVariable;
            cboIdAluno.DropDownHeight = 174;
            cboIdAluno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdAluno.DropDownWidth = 121;
            cboIdAluno.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboIdAluno.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboIdAluno.FormattingEnabled = true;
            cboIdAluno.Hint = "Id Do Aluno";
            cboIdAluno.IntegralHeight = false;
            cboIdAluno.ItemHeight = 43;
            cboIdAluno.Location = new Point(20, 20);
            cboIdAluno.MaxDropDownItems = 4;
            cboIdAluno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboIdAluno.Name = "cboIdAluno";
            cboIdAluno.Size = new Size(350, 49);
            cboIdAluno.StartIndex = 0;
            cboIdAluno.TabIndex = 4;
            // 
            // cboIdModalidade
            // 
            cboIdModalidade.AutoResize = false;
            cboIdModalidade.BackColor = Color.FromArgb(255, 255, 255);
            cboIdModalidade.Depth = 0;
            cboIdModalidade.DrawMode = DrawMode.OwnerDrawVariable;
            cboIdModalidade.DropDownHeight = 174;
            cboIdModalidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdModalidade.DropDownWidth = 121;
            cboIdModalidade.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboIdModalidade.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboIdModalidade.FormattingEnabled = true;
            cboIdModalidade.Hint = "Id Da Modalidade";
            cboIdModalidade.IntegralHeight = false;
            cboIdModalidade.ItemHeight = 43;
            cboIdModalidade.Location = new Point(376, 20);
            cboIdModalidade.MaxDropDownItems = 4;
            cboIdModalidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboIdModalidade.Name = "cboIdModalidade";
            cboIdModalidade.Size = new Size(398, 49);
            cboIdModalidade.StartIndex = 0;
            cboIdModalidade.TabIndex = 5;
            // 
            // CadastroAlunoModalidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroAlunoModalidade";
            Text = "CadastroAlunoModalidade";
            tabControlBase.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboIdModalidade;
        private ReaLTaiizor.Controls.MaterialComboBox cboIdAluno;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textAtivo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textDataInicio;
    }
}
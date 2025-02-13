namespace AcademiaLPL.Cadastros
{
    partial class CadastroProfessor
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
            textId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            textNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTelefone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            textEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            textEspecialidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            textAtivo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            //tabControlBase.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPageCadastro.Controls.Add(textAtivo);
            tabPageCadastro.Controls.Add(textEspecialidade);
            tabPageCadastro.Controls.Add(textEmail);
            tabPageCadastro.Controls.Add(txtTelefone);
            tabPageCadastro.Controls.Add(textNome);
            tabPageCadastro.Controls.Add(textId);
            tabPageCadastro.Controls.SetChildIndex(textId, 0);
            tabPageCadastro.Controls.SetChildIndex(textNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtTelefone, 0);
            tabPageCadastro.Controls.SetChildIndex(textEmail, 0);
            tabPageCadastro.Controls.SetChildIndex(textEspecialidade, 0);
            tabPageCadastro.Controls.SetChildIndex(textAtivo, 0);
            // 
            // textId
            // 
            textId.AnimateReadOnly = false;
            textId.AutoCompleteMode = AutoCompleteMode.None;
            textId.AutoCompleteSource = AutoCompleteSource.None;
            textId.BackgroundImageLayout = ImageLayout.None;
            textId.CharacterCasing = CharacterCasing.Normal;
            textId.Depth = 0;
            textId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textId.HideSelection = true;
            textId.Hint = "Id";
            textId.LeadingIcon = null;
            textId.Location = new Point(6, 17);
            textId.MaxLength = 32767;
            textId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textId.Name = "textId";
            textId.PasswordChar = '\0';
            textId.PrefixSuffixText = null;
            textId.ReadOnly = true;
            textId.RightToLeft = RightToLeft.No;
            textId.SelectedText = "";
            textId.SelectionLength = 0;
            textId.SelectionStart = 0;
            textId.ShortcutsEnabled = true;
            textId.Size = new Size(77, 48);
            textId.TabIndex = 2;
            textId.TabStop = false;
            textId.TextAlign = HorizontalAlignment.Left;
            textId.TrailingIcon = null;
            textId.UseSystemPasswordChar = false;
            // 
            // textNome
            // 
            textNome.AnimateReadOnly = false;
            textNome.AutoCompleteMode = AutoCompleteMode.None;
            textNome.AutoCompleteSource = AutoCompleteSource.None;
            textNome.BackgroundImageLayout = ImageLayout.None;
            textNome.CharacterCasing = CharacterCasing.Normal;
            textNome.Depth = 0;
            textNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textNome.HideSelection = true;
            textNome.Hint = "Nome do Professor";
            textNome.LeadingIcon = null;
            textNome.Location = new Point(89, 17);
            textNome.MaxLength = 32767;
            textNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textNome.Name = "textNome";
            textNome.PasswordChar = '\0';
            textNome.PrefixSuffixText = null;
            textNome.ReadOnly = false;
            textNome.RightToLeft = RightToLeft.No;
            textNome.SelectedText = "";
            textNome.SelectionLength = 0;
            textNome.SelectionStart = 0;
            textNome.ShortcutsEnabled = true;
            textNome.Size = new Size(685, 48);
            textNome.TabIndex = 3;
            textNome.TabStop = false;
            textNome.TextAlign = HorizontalAlignment.Left;
            textNome.TrailingIcon = null;
            textNome.UseSystemPasswordChar = false;
            // 
            // txtTelefone
            // 
            txtTelefone.AnimateReadOnly = false;
            txtTelefone.AutoCompleteMode = AutoCompleteMode.None;
            txtTelefone.AutoCompleteSource = AutoCompleteSource.None;
            txtTelefone.BackgroundImageLayout = ImageLayout.None;
            txtTelefone.CharacterCasing = CharacterCasing.Normal;
            txtTelefone.Depth = 0;
            txtTelefone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefone.HideSelection = true;
            txtTelefone.Hint = "Telefone (DD) 00000-0000";
            txtTelefone.LeadingIcon = null;
            txtTelefone.Location = new Point(6, 71);
            txtTelefone.MaxLength = 32767;
            txtTelefone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PasswordChar = '\0';
            txtTelefone.PrefixSuffixText = null;
            txtTelefone.ReadOnly = false;
            txtTelefone.RightToLeft = RightToLeft.No;
            txtTelefone.SelectedText = "";
            txtTelefone.SelectionLength = 0;
            txtTelefone.SelectionStart = 0;
            txtTelefone.ShortcutsEnabled = true;
            txtTelefone.Size = new Size(679, 48);
            txtTelefone.TabIndex = 4;
            txtTelefone.TabStop = false;
            txtTelefone.TextAlign = HorizontalAlignment.Left;
            txtTelefone.TrailingIcon = null;
            txtTelefone.UseSystemPasswordChar = false;
            // 
            // textEmail
            // 
            textEmail.AnimateReadOnly = false;
            textEmail.AutoCompleteMode = AutoCompleteMode.None;
            textEmail.AutoCompleteSource = AutoCompleteSource.None;
            textEmail.BackgroundImageLayout = ImageLayout.None;
            textEmail.CharacterCasing = CharacterCasing.Normal;
            textEmail.Depth = 0;
            textEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textEmail.HideSelection = true;
            textEmail.Hint = "Email";
            textEmail.LeadingIcon = null;
            textEmail.Location = new Point(6, 179);
            textEmail.MaxLength = 32767;
            textEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textEmail.Name = "textEmail";
            textEmail.PasswordChar = '\0';
            textEmail.PrefixSuffixText = null;
            textEmail.ReadOnly = false;
            textEmail.RightToLeft = RightToLeft.No;
            textEmail.SelectedText = "";
            textEmail.SelectionLength = 0;
            textEmail.SelectionStart = 0;
            textEmail.ShortcutsEnabled = true;
            textEmail.Size = new Size(364, 48);
            textEmail.TabIndex = 5;
            textEmail.TabStop = false;
            textEmail.TextAlign = HorizontalAlignment.Left;
            textEmail.TrailingIcon = null;
            textEmail.UseSystemPasswordChar = false;
            // 
            // textEspecialidade
            // 
            textEspecialidade.AnimateReadOnly = false;
            textEspecialidade.AutoCompleteMode = AutoCompleteMode.None;
            textEspecialidade.AutoCompleteSource = AutoCompleteSource.None;
            textEspecialidade.BackgroundImageLayout = ImageLayout.None;
            textEspecialidade.CharacterCasing = CharacterCasing.Normal;
            textEspecialidade.Depth = 0;
            textEspecialidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textEspecialidade.HideSelection = true;
            textEspecialidade.Hint = "Especialidade Do Professor";
            textEspecialidade.LeadingIcon = null;
            textEspecialidade.Location = new Point(6, 125);
            textEspecialidade.MaxLength = 32767;
            textEspecialidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textEspecialidade.Name = "textEspecialidade";
            textEspecialidade.PasswordChar = '\0';
            textEspecialidade.PrefixSuffixText = null;
            textEspecialidade.ReadOnly = false;
            textEspecialidade.RightToLeft = RightToLeft.No;
            textEspecialidade.SelectedText = "";
            textEspecialidade.SelectionLength = 0;
            textEspecialidade.SelectionStart = 0;
            textEspecialidade.ShortcutsEnabled = true;
            textEspecialidade.Size = new Size(768, 48);
            textEspecialidade.TabIndex = 6;
            textEspecialidade.TabStop = false;
            textEspecialidade.TextAlign = HorizontalAlignment.Left;
            textEspecialidade.TrailingIcon = null;
            textEspecialidade.UseSystemPasswordChar = false;
            // 
            // textAtivo
            // 
            textAtivo.AnimateReadOnly = false;
            textAtivo.AutoCompleteMode = AutoCompleteMode.None;
            textAtivo.AutoCompleteSource = AutoCompleteSource.None;
            textAtivo.BackgroundImageLayout = ImageLayout.None;
            textAtivo.CharacterCasing = CharacterCasing.Normal;
            textAtivo.Depth = 0;
            textAtivo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textAtivo.HideSelection = true;
            textAtivo.Hint = "Ativo";
            textAtivo.LeadingIcon = null;
            textAtivo.Location = new Point(691, 71);
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
            textAtivo.Size = new Size(83, 48);
            textAtivo.TabIndex = 7;
            textAtivo.TabStop = false;
            textAtivo.TextAlign = HorizontalAlignment.Left;
            textAtivo.TrailingIcon = null;
            textAtivo.UseSystemPasswordChar = false;
            // 
            // CadastroProfessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroProfessor";
            Text = "CadastroProfessor";
            //tabControlBase.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit textAtivo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textEspecialidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTelefone;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textId;
    }
}
namespace AcademiaLPL.Cadastros
{
    partial class CadastroModalidade
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
            textDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            textPreco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlBase.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textPreco);
            tabPage1.Controls.Add(textDescricao);
            tabPage1.Controls.Add(textNome);
            tabPage1.Controls.Add(textId);
            tabPage1.Controls.SetChildIndex(textId, 0);
            tabPage1.Controls.SetChildIndex(textNome, 0);
            tabPage1.Controls.SetChildIndex(textDescricao, 0);
            tabPage1.Controls.SetChildIndex(textPreco, 0);
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
            textId.Location = new Point(23, 20);
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
            textId.Size = new Size(48, 48);
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
            textNome.Hint = "Nome Da Modalidade";
            textNome.LeadingIcon = null;
            textNome.Location = new Point(77, 20);
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
            textNome.Size = new Size(697, 48);
            textNome.TabIndex = 3;
            textNome.TabStop = false;
            textNome.TextAlign = HorizontalAlignment.Left;
            textNome.TrailingIcon = null;
            textNome.UseSystemPasswordChar = false;
            // 
            // textDescricao
            // 
            textDescricao.AnimateReadOnly = false;
            textDescricao.AutoCompleteMode = AutoCompleteMode.None;
            textDescricao.AutoCompleteSource = AutoCompleteSource.None;
            textDescricao.BackgroundImageLayout = ImageLayout.None;
            textDescricao.CharacterCasing = CharacterCasing.Normal;
            textDescricao.Depth = 0;
            textDescricao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textDescricao.HideSelection = true;
            textDescricao.Hint = "Descrição da Modalidade";
            textDescricao.LeadingIcon = null;
            textDescricao.Location = new Point(23, 74);
            textDescricao.MaxLength = 32767;
            textDescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textDescricao.Name = "textDescricao";
            textDescricao.PasswordChar = '\0';
            textDescricao.PrefixSuffixText = null;
            textDescricao.ReadOnly = false;
            textDescricao.RightToLeft = RightToLeft.No;
            textDescricao.SelectedText = "";
            textDescricao.SelectionLength = 0;
            textDescricao.SelectionStart = 0;
            textDescricao.ShortcutsEnabled = true;
            textDescricao.Size = new Size(751, 48);
            textDescricao.TabIndex = 4;
            textDescricao.TabStop = false;
            textDescricao.TextAlign = HorizontalAlignment.Left;
            textDescricao.TrailingIcon = null;
            textDescricao.UseSystemPasswordChar = false;
            // 
            // textPreco
            // 
            textPreco.AnimateReadOnly = false;
            textPreco.AutoCompleteMode = AutoCompleteMode.None;
            textPreco.AutoCompleteSource = AutoCompleteSource.None;
            textPreco.BackgroundImageLayout = ImageLayout.None;
            textPreco.CharacterCasing = CharacterCasing.Normal;
            textPreco.Depth = 0;
            textPreco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textPreco.HideSelection = true;
            textPreco.Hint = "Preço Mensal R$";
            textPreco.LeadingIcon = null;
            textPreco.Location = new Point(23, 128);
            textPreco.MaxLength = 32767;
            textPreco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textPreco.Name = "textPreco";
            textPreco.PasswordChar = '\0';
            textPreco.PrefixSuffixText = null;
            textPreco.ReadOnly = false;
            textPreco.RightToLeft = RightToLeft.No;
            textPreco.SelectedText = "";
            textPreco.SelectionLength = 0;
            textPreco.SelectionStart = 0;
            textPreco.ShortcutsEnabled = true;
            textPreco.Size = new Size(250, 48);
            textPreco.TabIndex = 5;
            textPreco.TabStop = false;
            textPreco.TextAlign = HorizontalAlignment.Left;
            textPreco.TrailingIcon = null;
            textPreco.UseSystemPasswordChar = false;
            // 
            // CadastroModalidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroModalidade";
            Text = "CadastroModalidade";
            tabControlBase.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit textPreco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textDescricao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textId;
    }
}
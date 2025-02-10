namespace AcademiaLPL.Cadastros
{
    partial class CadastroAula
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
            textDiaAula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            textHoraInicio = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            textHoraFim = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboIdModalidade = new ReaLTaiizor.Controls.MaterialComboBox();
            cboIdProfessor = new ReaLTaiizor.Controls.MaterialComboBox();
            tabControlBase.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cboIdProfessor);
            tabPage1.Controls.Add(cboIdModalidade);
            tabPage1.Controls.Add(textHoraFim);
            tabPage1.Controls.Add(textHoraInicio);
            tabPage1.Controls.Add(textDiaAula);
            tabPage1.Controls.Add(textId);
            tabPage1.Controls.SetChildIndex(textId, 0);
            tabPage1.Controls.SetChildIndex(textDiaAula, 0);
            tabPage1.Controls.SetChildIndex(textHoraInicio, 0);
            tabPage1.Controls.SetChildIndex(textHoraFim, 0);
            tabPage1.Controls.SetChildIndex(cboIdModalidade, 0);
            tabPage1.Controls.SetChildIndex(cboIdProfessor, 0);
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
            textId.Location = new Point(6, 6);
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
            textId.Size = new Size(85, 48);
            textId.TabIndex = 2;
            textId.TabStop = false;
            textId.TextAlign = HorizontalAlignment.Left;
            textId.TrailingIcon = null;
            textId.UseSystemPasswordChar = false;
            // 
            // textDiaAula
            // 
            textDiaAula.AnimateReadOnly = false;
            textDiaAula.AutoCompleteMode = AutoCompleteMode.None;
            textDiaAula.AutoCompleteSource = AutoCompleteSource.None;
            textDiaAula.BackgroundImageLayout = ImageLayout.None;
            textDiaAula.CharacterCasing = CharacterCasing.Normal;
            textDiaAula.Depth = 0;
            textDiaAula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textDiaAula.HideSelection = true;
            textDiaAula.Hint = "Dia Na Semana Da Aula";
            textDiaAula.LeadingIcon = null;
            textDiaAula.Location = new Point(6, 60);
            textDiaAula.MaxLength = 32767;
            textDiaAula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textDiaAula.Name = "textDiaAula";
            textDiaAula.PasswordChar = '\0';
            textDiaAula.PrefixSuffixText = null;
            textDiaAula.ReadOnly = false;
            textDiaAula.RightToLeft = RightToLeft.No;
            textDiaAula.SelectedText = "";
            textDiaAula.SelectionLength = 0;
            textDiaAula.SelectionStart = 0;
            textDiaAula.ShortcutsEnabled = true;
            textDiaAula.Size = new Size(768, 48);
            textDiaAula.TabIndex = 5;
            textDiaAula.TabStop = false;
            textDiaAula.TextAlign = HorizontalAlignment.Left;
            textDiaAula.TrailingIcon = null;
            textDiaAula.UseSystemPasswordChar = false;
            // 
            // textHoraInicio
            // 
            textHoraInicio.AnimateReadOnly = false;
            textHoraInicio.AutoCompleteMode = AutoCompleteMode.None;
            textHoraInicio.AutoCompleteSource = AutoCompleteSource.None;
            textHoraInicio.BackgroundImageLayout = ImageLayout.None;
            textHoraInicio.CharacterCasing = CharacterCasing.Normal;
            textHoraInicio.Depth = 0;
            textHoraInicio.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textHoraInicio.HideSelection = true;
            textHoraInicio.Hint = "Horario De Inicio";
            textHoraInicio.LeadingIcon = null;
            textHoraInicio.Location = new Point(6, 114);
            textHoraInicio.MaxLength = 32767;
            textHoraInicio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textHoraInicio.Name = "textHoraInicio";
            textHoraInicio.PasswordChar = '\0';
            textHoraInicio.PrefixSuffixText = null;
            textHoraInicio.ReadOnly = false;
            textHoraInicio.RightToLeft = RightToLeft.No;
            textHoraInicio.SelectedText = "";
            textHoraInicio.SelectionLength = 0;
            textHoraInicio.SelectionStart = 0;
            textHoraInicio.ShortcutsEnabled = true;
            textHoraInicio.Size = new Size(354, 48);
            textHoraInicio.TabIndex = 6;
            textHoraInicio.TabStop = false;
            textHoraInicio.TextAlign = HorizontalAlignment.Left;
            textHoraInicio.TrailingIcon = null;
            textHoraInicio.UseSystemPasswordChar = false;
            // 
            // textHoraFim
            // 
            textHoraFim.AnimateReadOnly = false;
            textHoraFim.AutoCompleteMode = AutoCompleteMode.None;
            textHoraFim.AutoCompleteSource = AutoCompleteSource.None;
            textHoraFim.BackgroundImageLayout = ImageLayout.None;
            textHoraFim.CharacterCasing = CharacterCasing.Normal;
            textHoraFim.Depth = 0;
            textHoraFim.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textHoraFim.HideSelection = true;
            textHoraFim.Hint = "Horario de Finalização";
            textHoraFim.LeadingIcon = null;
            textHoraFim.Location = new Point(366, 114);
            textHoraFim.MaxLength = 32767;
            textHoraFim.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textHoraFim.Name = "textHoraFim";
            textHoraFim.PasswordChar = '\0';
            textHoraFim.PrefixSuffixText = null;
            textHoraFim.ReadOnly = false;
            textHoraFim.RightToLeft = RightToLeft.No;
            textHoraFim.SelectedText = "";
            textHoraFim.SelectionLength = 0;
            textHoraFim.SelectionStart = 0;
            textHoraFim.ShortcutsEnabled = true;
            textHoraFim.Size = new Size(408, 48);
            textHoraFim.TabIndex = 7;
            textHoraFim.TabStop = false;
            textHoraFim.TextAlign = HorizontalAlignment.Left;
            textHoraFim.TrailingIcon = null;
            textHoraFim.UseSystemPasswordChar = false;
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
            cboIdModalidade.Hint = "Id Da Modalide";
            cboIdModalidade.IntegralHeight = false;
            cboIdModalidade.ItemHeight = 43;
            cboIdModalidade.Location = new Point(97, 6);
            cboIdModalidade.MaxDropDownItems = 4;
            cboIdModalidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboIdModalidade.Name = "cboIdModalidade";
            cboIdModalidade.Size = new Size(317, 49);
            cboIdModalidade.StartIndex = 0;
            cboIdModalidade.TabIndex = 8;
            // 
            // cboIdProfessor
            // 
            cboIdProfessor.AutoResize = false;
            cboIdProfessor.BackColor = Color.FromArgb(255, 255, 255);
            cboIdProfessor.Depth = 0;
            cboIdProfessor.DrawMode = DrawMode.OwnerDrawVariable;
            cboIdProfessor.DropDownHeight = 174;
            cboIdProfessor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdProfessor.DropDownWidth = 121;
            cboIdProfessor.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboIdProfessor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboIdProfessor.FormattingEnabled = true;
            cboIdProfessor.Hint = "Id Do Professor";
            cboIdProfessor.IntegralHeight = false;
            cboIdProfessor.ItemHeight = 43;
            cboIdProfessor.Location = new Point(420, 6);
            cboIdProfessor.MaxDropDownItems = 4;
            cboIdProfessor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboIdProfessor.Name = "cboIdProfessor";
            cboIdProfessor.Size = new Size(354, 49);
            cboIdProfessor.StartIndex = 0;
            cboIdProfessor.TabIndex = 9;
            // 
            // CadastroAula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroAula";
            Text = "CadastroAula";
            tabControlBase.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit textHoraInicio;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textDiaAula;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textHoraFim;
        private ReaLTaiizor.Controls.MaterialComboBox cboIdModalidade;
        private ReaLTaiizor.Controls.MaterialComboBox cboIdProfessor;
    }
}
﻿namespace AcademiaLPL
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            modalidadeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            professorToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            alunoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            aulaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            alunoModalidadeToolStripMenuItem = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(641, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modalidadeToolStripMenuItem, toolStripSeparator1, professorToolStripMenuItem, toolStripSeparator2, alunoToolStripMenuItem, toolStripSeparator3, aulaToolStripMenuItem, toolStripSeparator4, alunoModalidadeToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // modalidadeToolStripMenuItem
            // 
            modalidadeToolStripMenuItem.Name = "modalidadeToolStripMenuItem";
            modalidadeToolStripMenuItem.Size = new Size(172, 22);
            modalidadeToolStripMenuItem.Text = "Modalidade";
            modalidadeToolStripMenuItem.Click += modalidadeToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(169, 6);
            // 
            // professorToolStripMenuItem
            // 
            professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            professorToolStripMenuItem.Size = new Size(172, 22);
            professorToolStripMenuItem.Text = "Professor";
            professorToolStripMenuItem.Click += professorToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(169, 6);
            // 
            // alunoToolStripMenuItem
            // 
            alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            alunoToolStripMenuItem.Size = new Size(172, 22);
            alunoToolStripMenuItem.Text = "Aluno";
            alunoToolStripMenuItem.Click += alunoToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(169, 6);
            // 
            // aulaToolStripMenuItem
            // 
            aulaToolStripMenuItem.Name = "aulaToolStripMenuItem";
            aulaToolStripMenuItem.Size = new Size(172, 22);
            aulaToolStripMenuItem.Text = "Aula";
            aulaToolStripMenuItem.Click += aulaToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(169, 6);
            // 
            // alunoModalidadeToolStripMenuItem
            // 
            alunoModalidadeToolStripMenuItem.Name = "alunoModalidadeToolStripMenuItem";
            alunoModalidadeToolStripMenuItem.Size = new Size(172, 22);
            alunoModalidadeToolStripMenuItem.Text = "Aluno Modalidade";
            alunoModalidadeToolStripMenuItem.Click += alunoModalidadeToolStripMenuItem_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "cadastro.png");
            imageList1.Images.SetKeyName(1, "luvas-de-boxe.png");
            imageList1.Images.SetKeyName(2, "procurando.png");
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.karateMuayThai1;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(647, 300);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "Sistema AcademiaLPL";
            FormClosing += FormPrincipal_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem modalidadeToolStripMenuItem;
        private ToolStripMenuItem professorToolStripMenuItem;
        private ToolStripMenuItem alunoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem aulaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem alunoModalidadeToolStripMenuItem;
        private ImageList imageList1;
    }
}

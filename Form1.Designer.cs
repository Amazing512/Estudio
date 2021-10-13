
namespace Estudio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarTurmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verModalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.turmasToolStripMenuItem,
            this.modalidadesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.pesquisaToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cadastrarToolStripMenuItem.Text = "Aluno";
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.pesquisaToolStripMenuItem.Text = "Consultar";
            this.pesquisaToolStripMenuItem.Click += new System.EventHandler(this.pesquisaToolStripMenuItem_Click);
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarTurmasToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.turmasToolStripMenuItem.Text = "Turmas";
            // 
            // pesquisarTurmasToolStripMenuItem
            // 
            this.pesquisarTurmasToolStripMenuItem.Name = "pesquisarTurmasToolStripMenuItem";
            this.pesquisarTurmasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pesquisarTurmasToolStripMenuItem.Text = "Cadastrar";
            this.pesquisarTurmasToolStripMenuItem.Click += new System.EventHandler(this.pesquisarTurmasToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // modalidadesToolStripMenuItem
            // 
            this.modalidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verModalidadesToolStripMenuItem,
            this.consultarToolStripMenuItem1});
            this.modalidadesToolStripMenuItem.Name = "modalidadesToolStripMenuItem";
            this.modalidadesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.modalidadesToolStripMenuItem.Text = "Modalidades";
            // 
            // verModalidadesToolStripMenuItem
            // 
            this.verModalidadesToolStripMenuItem.Name = "verModalidadesToolStripMenuItem";
            this.verModalidadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verModalidadesToolStripMenuItem.Text = "Cadastrar";
            this.verModalidadesToolStripMenuItem.Click += new System.EventHandler(this.verModalidadesToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Estúdio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarTurmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verModalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
    }
}


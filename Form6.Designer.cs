
namespace Estudio
{
    partial class Form6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblQtdAulas = new System.Windows.Forms.Label();
            this.lblQtdAlunos = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtQtdAulas = new System.Windows.Forms.TextBox();
            this.txtQtdAlunos = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtPrecoo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrecoo);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txtQtdAlunos);
            this.groupBox1.Controls.Add(this.txtQtdAulas);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.lblQtdAlunos);
            this.groupBox1.Controls.Add(this.lblQtdAulas);
            this.groupBox1.Controls.Add(this.lblPreco);
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados ";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(60, 40);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(80, 66);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço:";
            // 
            // lblQtdAulas
            // 
            this.lblQtdAulas.AutoSize = true;
            this.lblQtdAulas.Location = new System.Drawing.Point(9, 92);
            this.lblQtdAulas.Name = "lblQtdAulas";
            this.lblQtdAulas.Size = new System.Drawing.Size(109, 13);
            this.lblQtdAulas.TabIndex = 2;
            this.lblQtdAulas.Text = "Quantidade de Aulas:";
            // 
            // lblQtdAlunos
            // 
            this.lblQtdAlunos.AutoSize = true;
            this.lblQtdAlunos.Location = new System.Drawing.Point(22, 118);
            this.lblQtdAlunos.Name = "lblQtdAlunos";
            this.lblQtdAlunos.Size = new System.Drawing.Size(96, 13);
            this.lblQtdAlunos.TabIndex = 3;
            this.lblQtdAlunos.Text = "Maximo de Alunos:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(124, 37);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(398, 20);
            this.txtDescricao.TabIndex = 4;
            // 
            // txtQtdAulas
            // 
            this.txtQtdAulas.Location = new System.Drawing.Point(124, 89);
            this.txtQtdAulas.Name = "txtQtdAulas";
            this.txtQtdAulas.Size = new System.Drawing.Size(100, 20);
            this.txtQtdAulas.TabIndex = 6;
            // 
            // txtQtdAlunos
            // 
            this.txtQtdAlunos.Location = new System.Drawing.Point(124, 115);
            this.txtQtdAlunos.Name = "txtQtdAlunos";
            this.txtQtdAlunos.Size = new System.Drawing.Size(100, 20);
            this.txtQtdAlunos.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 141);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(510, 23);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtPrecoo
            // 
            this.txtPrecoo.Location = new System.Drawing.Point(124, 63);
            this.txtPrecoo.Name = "txtPrecoo";
            this.txtPrecoo.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoo.TabIndex = 8;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Cadastro Modalidades";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQtdAlunos;
        private System.Windows.Forms.Label lblQtdAulas;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtQtdAlunos;
        private System.Windows.Forms.TextBox txtQtdAulas;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtPrecoo;
    }
}
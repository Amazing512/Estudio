
namespace Estudio
{
    partial class Form10
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
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.gpbMatriculas = new System.Windows.Forms.GroupBox();
            this.btnExcluirMatricula = new System.Windows.Forms.Button();
            this.btnVerTurma = new System.Windows.Forms.Button();
            this.dgvMatriculas = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMatriculas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gpbMatriculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.gpbMatriculas);
            this.groupBox1.Controls.Add(this.btnMatriculas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 519);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(91, 33);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(121, 20);
            this.txtCPF.TabIndex = 6;
            // 
            // gpbMatriculas
            // 
            this.gpbMatriculas.Controls.Add(this.btnExcluirMatricula);
            this.gpbMatriculas.Controls.Add(this.btnVerTurma);
            this.gpbMatriculas.Controls.Add(this.dgvMatriculas);
            this.gpbMatriculas.Location = new System.Drawing.Point(23, 62);
            this.gpbMatriculas.Name = "gpbMatriculas";
            this.gpbMatriculas.Size = new System.Drawing.Size(507, 311);
            this.gpbMatriculas.TabIndex = 5;
            this.gpbMatriculas.TabStop = false;
            this.gpbMatriculas.Text = "Matrículas:";
            this.gpbMatriculas.Visible = false;
            // 
            // btnExcluirMatricula
            // 
            this.btnExcluirMatricula.Location = new System.Drawing.Point(388, 282);
            this.btnExcluirMatricula.Name = "btnExcluirMatricula";
            this.btnExcluirMatricula.Size = new System.Drawing.Size(113, 23);
            this.btnExcluirMatricula.TabIndex = 2;
            this.btnExcluirMatricula.Text = "Excluir Matrícula";
            this.btnExcluirMatricula.UseVisualStyleBackColor = true;
            this.btnExcluirMatricula.Click += new System.EventHandler(this.btnExcluirMatricula_Click);
            // 
            // btnVerTurma
            // 
            this.btnVerTurma.Location = new System.Drawing.Point(307, 282);
            this.btnVerTurma.Name = "btnVerTurma";
            this.btnVerTurma.Size = new System.Drawing.Size(75, 23);
            this.btnVerTurma.TabIndex = 1;
            this.btnVerTurma.Text = "Ver Turma";
            this.btnVerTurma.UseVisualStyleBackColor = true;
            this.btnVerTurma.Click += new System.EventHandler(this.btnVerTurma_Click);
            // 
            // dgvMatriculas
            // 
            this.dgvMatriculas.AllowUserToAddRows = false;
            this.dgvMatriculas.AllowUserToDeleteRows = false;
            this.dgvMatriculas.AllowUserToOrderColumns = true;
            this.dgvMatriculas.AllowUserToResizeColumns = false;
            this.dgvMatriculas.AllowUserToResizeRows = false;
            this.dgvMatriculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtData});
            this.dgvMatriculas.Location = new System.Drawing.Point(3, 16);
            this.dgvMatriculas.MultiSelect = false;
            this.dgvMatriculas.Name = "dgvMatriculas";
            this.dgvMatriculas.ReadOnly = true;
            this.dgvMatriculas.Size = new System.Drawing.Size(501, 259);
            this.dgvMatriculas.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.HeaderText = "ID Turma";
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            // 
            // txtData
            // 
            this.txtData.HeaderText = "Data de Ingresso";
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            // 
            // btnMatriculas
            // 
            this.btnMatriculas.Location = new System.Drawing.Point(218, 33);
            this.btnMatriculas.Name = "btnMatriculas";
            this.btnMatriculas.Size = new System.Drawing.Size(134, 23);
            this.btnMatriculas.TabIndex = 4;
            this.btnMatriculas.Text = "Pesquisar Matrículas";
            this.btnMatriculas.UseVisualStyleBackColor = true;
            this.btnMatriculas.Click += new System.EventHandler(this.btnMatriculas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF:";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 679);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form10";
            this.Text = "Pesquisa Matrícula";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbMatriculas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.GroupBox gpbMatriculas;
        private System.Windows.Forms.Button btnVerTurma;
        private System.Windows.Forms.DataGridView dgvMatriculas;
        private System.Windows.Forms.Button btnMatriculas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtData;
    }
}

namespace Estudio
{
    partial class Form9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbModalidades = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.gpbTurmas = new System.Windows.Forms.GroupBox();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.dgvTurmas = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiaSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gpbTurmas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).BeginInit();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modalidade:";
            // 
            // cbbModalidades
            // 
            this.cbbModalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbModalidades.FormattingEnabled = true;
            this.cbbModalidades.Location = new System.Drawing.Point(91, 68);
            this.cbbModalidades.Name = "cbbModalidades";
            this.cbbModalidades.Size = new System.Drawing.Size(121, 21);
            this.cbbModalidades.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.gpbTurmas);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbbModalidades);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 519);
            this.groupBox1.TabIndex = 4;
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
            // gpbTurmas
            // 
            this.gpbTurmas.Controls.Add(this.btnMatricula);
            this.gpbTurmas.Controls.Add(this.dgvTurmas);
            this.gpbTurmas.Location = new System.Drawing.Point(23, 108);
            this.gpbTurmas.Name = "gpbTurmas";
            this.gpbTurmas.Size = new System.Drawing.Size(507, 311);
            this.gpbTurmas.TabIndex = 5;
            this.gpbTurmas.TabStop = false;
            this.gpbTurmas.Text = "Turmas:";
            this.gpbTurmas.Visible = false;
            // 
            // btnMatricula
            // 
            this.btnMatricula.Location = new System.Drawing.Point(426, 281);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(75, 23);
            this.btnMatricula.TabIndex = 1;
            this.btnMatricula.Text = "Matricular-se";
            this.btnMatricula.UseVisualStyleBackColor = true;
            this.btnMatricula.Click += new System.EventHandler(this.btnMatricula_Click);
            // 
            // dgvTurmas
            // 
            this.dgvTurmas.AllowUserToAddRows = false;
            this.dgvTurmas.AllowUserToDeleteRows = false;
            this.dgvTurmas.AllowUserToOrderColumns = true;
            this.dgvTurmas.AllowUserToResizeColumns = false;
            this.dgvTurmas.AllowUserToResizeRows = false;
            this.dgvTurmas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurmas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtProfessor,
            this.txtDiaSemana,
            this.txtHora});
            this.dgvTurmas.Location = new System.Drawing.Point(3, 16);
            this.dgvTurmas.MultiSelect = false;
            this.dgvTurmas.Name = "dgvTurmas";
            this.dgvTurmas.ReadOnly = true;
            this.dgvTurmas.Size = new System.Drawing.Size(501, 259);
            this.dgvTurmas.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.HeaderText = "ID";
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            // 
            // txtProfessor
            // 
            this.txtProfessor.HeaderText = "Professor";
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.ReadOnly = true;
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.HeaderText = "Dia da Semana";
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.ReadOnly = true;
            // 
            // txtHora
            // 
            this.txtHora.HeaderText = "Hora";
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pesquisar Turmas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 697);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form9";
            this.Text = "Cadastro Matrícula";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbTurmas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbModalidades;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gpbTurmas;
        private System.Windows.Forms.DataGridView dgvTurmas;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDiaSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtHora;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Button btnMatricula;
    }
}

namespace Estudio
{
    partial class Form12
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
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.dgvMensalidades = new System.Windows.Forms.DataGridView();
            this.gpbMensalidades = new System.Windows.Forms.GroupBox();
            this.txtMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensalidades)).BeginInit();
            this.gpbMensalidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(48, 6);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 1;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(154, 6);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(128, 23);
            this.btnExibir.TabIndex = 2;
            this.btnExibir.Text = "Exibir Mensalidades";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // dgvMensalidades
            // 
            this.dgvMensalidades.AllowUserToAddRows = false;
            this.dgvMensalidades.AllowUserToDeleteRows = false;
            this.dgvMensalidades.AllowUserToOrderColumns = true;
            this.dgvMensalidades.AllowUserToResizeColumns = false;
            this.dgvMensalidades.AllowUserToResizeRows = false;
            this.dgvMensalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMensalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMensalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtMes,
            this.txtValor,
            this.txtPago});
            this.dgvMensalidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMensalidades.Location = new System.Drawing.Point(3, 16);
            this.dgvMensalidades.MultiSelect = false;
            this.dgvMensalidades.Name = "dgvMensalidades";
            this.dgvMensalidades.ReadOnly = true;
            this.dgvMensalidades.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvMensalidades.Size = new System.Drawing.Size(660, 344);
            this.dgvMensalidades.TabIndex = 3;
            // 
            // gpbMensalidades
            // 
            this.gpbMensalidades.Controls.Add(this.btnPagar);
            this.gpbMensalidades.Controls.Add(this.dgvMensalidades);
            this.gpbMensalidades.Location = new System.Drawing.Point(15, 48);
            this.gpbMensalidades.Name = "gpbMensalidades";
            this.gpbMensalidades.Size = new System.Drawing.Size(666, 363);
            this.gpbMensalidades.TabIndex = 4;
            this.gpbMensalidades.TabStop = false;
            this.gpbMensalidades.Text = "Mensalidades";
            this.gpbMensalidades.Visible = false;
            // 
            // txtMes
            // 
            this.txtMes.HeaderText = "Mês de referência";
            this.txtMes.Name = "txtMes";
            this.txtMes.ReadOnly = true;
            this.txtMes.Width = 107;
            // 
            // txtValor
            // 
            this.txtValor.HeaderText = "Valor";
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Width = 56;
            // 
            // txtPago
            // 
            this.txtPago.HeaderText = "Situação";
            this.txtPago.Name = "txtPago";
            this.txtPago.ReadOnly = true;
            this.txtPago.Width = 74;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(585, 324);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbMensalidades);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label1);
            this.Name = "Form12";
            this.Text = "Efetuar Pagamento";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensalidades)).EndInit();
            this.gpbMensalidades.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.DataGridView dgvMensalidades;
        private System.Windows.Forms.GroupBox gpbMensalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPago;
        private System.Windows.Forms.Button btnPagar;
    }
}
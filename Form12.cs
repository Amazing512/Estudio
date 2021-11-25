using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class Form12 : Form
    {
        Form1 parent;
        string cpf;
        public Form12(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text.Trim().Equals("___.___.___-__")) MessageBox.Show("Digite um CPF!", "CPF Vazio");
            else
            {
                try
                {
                    cpf = txtCpf.Text.Trim();
                    getMensalidades();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro");
                }
            }
        }

        private void getMensalidades()
        {
            gpbMensalidades.Visible = false;
            dgvMensalidades.Rows.Clear();
            if (Aluno.buscaAluno(cpf) != null)
            {
                Mensalidade mensalidade = new Mensalidade(cpf);
                List<Mensalidade> mensalidadesList = mensalidade.Exibir_Mensalidades();
                foreach (Mensalidade mensa in mensalidadesList)
                {

                    dgvMensalidades.Rows.Add(mensa.getMes(), mensa.getValor(), (mensa.getPago() ? "Pago" : "A Pagar"));
                }
                gpbMensalidades.Visible = true;
            }
            
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if(dgvMensalidades.SelectedCells.Count > 0)
            {
                try
                {
                    int linha = dgvMensalidades.SelectedCells[0].RowIndex;
                    if (dgvMensalidades.Rows[linha].Cells[2].Value.ToString().Equals("Pago"))
                    {
                        MessageBox.Show("Esta mensalidade já está paga!", "Erro");
                        return;
                    }
                    Mensalidade ms = new Mensalidade(cpf, dgvMensalidades.Rows[linha].Cells[0].Value.ToString());
                    ms.Efetuar_Pagamento();
                    MessageBox.Show("Pagamento efetuado com sucesso!", "Sucesso");
                
                    getMensalidades();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma mensalidade para pagar!", "Erro");
            }
        }
    }
}

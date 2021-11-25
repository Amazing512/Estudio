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
    public partial class Form11 : Form
    {
        Form1 parent;
        public Form11(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text.Trim().Equals("___.___.___-__")) MessageBox.Show("Digite um CPF!", "CPF Vazio");
            else if(comboBox1.SelectedIndex.Equals(-1)) MessageBox.Show("Escolha um mês!", "Mês vazio");
            else
            {
                try
                {
                    if (Aluno.buscaAluno(txtCpf.Text.Trim()) != null)
                    {
                        Mensalidade mensalidade = new Mensalidade(txtCpf.Text, comboBox1.SelectedItem.ToString());
                        if (mensalidade.Gerar_Mensalidade())
                        {
                            MessageBox.Show("Mensalidade gerada com sucesso!", "Sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Não existem matriculas ativas para esse aluno!", "Erro");
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro");
                }
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}

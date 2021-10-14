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
    public partial class Form6 : Form
    {
        Form1 parent;
        public Form6(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                        txtDescricao.Text.Trim().Equals("") ||
                        txtPreco.Text.Trim().Equals("")     ||
                        txtQtdAulas.Text.Trim().Equals("")  ||
                        txtQtdAlunos.Text.Trim().Equals("")
                    )
                {
                    MessageBox.Show("Preencha todos os campos!", "Erro!");
                }
                else
                {
                    //Caso dê erro, é porque o campo não foi preenchido corretamente
                    double preco = Convert.ToDouble(txtPreco.Text.Trim());

                    Modalidades modalidade = new Modalidades(
                        txtDescricao.Text,
                        preco,
                        Convert.ToInt32(txtQtdAulas.Text),
                        Convert.ToInt32(txtQtdAlunos.Text)
                    );
                    modalidade.cadastrarModalidade();
                    limparTelaCadastro();
                    MessageBox.Show("Modalidade cadastrada com Sucesso!", "Sucesso!");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Preencha o horário corretamente!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void limparTelaCadastro()
        {
            txtDescricao.Text = "";
            txtPreco.Text = "";
            txtQtdAlunos.Text = "";
            txtQtdAulas.Text = "";
        }
    }
}

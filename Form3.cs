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
    public partial class Form3 : Form
    {
        public Form3(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        Form1 parent;

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!Methods.verificaCPF(txtCPF.Text))
                {
                    MessageBox.Show("CPF Inválido!", "ERRO");
                    txtCPF.Focus();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("CPF inválido!", "ERRO");
                txtCPF.Focus();
            }
        }

        private void btnEscolherFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Escolher foto";
            dialog.Filter = "JPG (*.jpg) |*.jpg" + "|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(dialog.OpenFile());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível cadastrar a foto:" + ex.ToString());
                }
            }
            dialog.Dispose();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.setCPF(txtCPF.Text);
            aluno.setNome(txtNome.Text);
            aluno.setRua(txtEndereco.Text);
            aluno.setNumero(txtNumero.Text);
            aluno.setBairro(txtBairro.Text);
            aluno.setComplemento(txtComplemento.Text);
            try
            {
                aluno.setCEP(int.Parse(txtCEP.Text));
            }
            catch
            {
                MessageBox.Show("Digite um CEP válido");
            }

            aluno.setCidade(txtCidade.Text);
            aluno.setEstado(txtEstado.Text);

            try
            {
                aluno.setTelefone(int.Parse(txtTelefone.Text));
            }
            catch
            {
                MessageBox.Show("Digite um Telefone válido");
            }
            aluno.setEmail(txtEmail.Text);
            aluno.setFoto(Methods.ConverterFotoParaByteArray(pictureBox1));
        }
    }
}

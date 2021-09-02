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
    public partial class Form4 : Form
    {
        Form1 parent;
        public Form4(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public void limpaCampos()
        {
            txtCPF.Text = txtCEP.Text = txtCidade.Text = txtComplemento.Text = txtBairro.Text = txtEmail.Text = txtEndereco.Text = txtEstado.Text = txtNome.Text = txtNumero.Text = txtTelefone.Text = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.setCPF(txtCPF.Text);
            aluno.setNome(txtNome.Text);
            aluno.setRua(txtEndereco.Text);
            aluno.setNumero(txtNumero.Text);
            aluno.setBairro(txtBairro.Text);
            aluno.setComplemento(txtComplemento.Text);
            aluno.setCidade(txtCidade.Text);
            aluno.setEstado(txtEstado.Text);
            aluno.setEmail(txtEmail.Text);
            aluno.setCEP(txtCEP.Text);
            aluno.setTelefone(txtTelefone.Text);
            byte[] foto = Methods.ConverterFotoParaByteArray(pictureBox1);
            aluno.setFoto(foto);

            if (aluno.alterarAluno())
            {
                MessageBox.Show("Atualizado com sucesso!", "SUCESSO");
                groupBox1.Visible = false;
                limpaCampos();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar!", "ERRO");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            Aluno aluno;
            try
            {
                aluno = Aluno.buscaAluno(txtCPF.Text);

                txtCPF.Text = aluno.getCPF();
                txtCEP.Text = aluno.getCEP();
                txtCidade.Text = aluno.getCidade();
                txtComplemento.Text = aluno.getComplemento();
                txtBairro.Text = aluno.getBairro();
                txtEmail.Text = aluno.getEmail();
                txtEndereco.Text = aluno.getRua();
                txtEstado.Text = aluno.getEstado();
                txtNome.Text = aluno.getNome();
                txtNumero.Text = aluno.getNumero();
                txtTelefone.Text = aluno.getTelefone();
                pictureBox1.Image = (Bitmap)((new ImageConverter()).ConvertFrom(aluno.getFoto()));
                groupBox1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text);
            DialogResult dialogResult = MessageBox.Show("Deseja mesmo excluir esse aluno?", "Confirmar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (aluno.excluirAluno()) MessageBox.Show("Aluno excluído com sucesso", "SUCESSO");
                    else MessageBox.Show("Falha ao excluir", "ERRO");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

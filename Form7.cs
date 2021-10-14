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
    
    public partial class Form7 : Form
    {
        Form1 parent;
        int idModalidade;

        public Form7(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Visible = false;
                idModalidade = Convert.ToInt32(txtId.Text.ToString());
                Modalidades modalidade = Modalidades.buscaModalidade(idModalidade);
                if (modalidade != null)
                {
                    txtDescricao.Text = modalidade.getDescricao();
                    txtPreco.Text = modalidade.getPreco().ToString();
                    txtQtdAulas.Text = modalidade.getQtde_aulas().ToString();
                    txtQtdAlunos.Text = modalidade.getQtde_alunos().ToString();

                    groupBox1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Modalidade não encontrada.");
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Digite um ID válido!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                        txtDescricao.Text.Trim().Equals("") || 
                        txtPreco.Text.Trim().Equals("") || 
                        txtQtdAulas.Text.Trim().Equals("") || 
                        txtQtdAlunos.Text.Trim().Equals("")
                    )  {
                    MessageBox.Show("Preencha todos os campos!", "Erro!");
                }
                else
                {
                    //Caso dê erro, é porque o campo não foi preenchido corretamente
                    double preco = Convert.ToDouble(txtPreco.Text.Trim());

                    Modalidades modalidade = new Modalidades(
                        idModalidade,
                        txtDescricao.Text,
                        preco,
                        Convert.ToInt32(txtQtdAulas.Text),
                        Convert.ToInt32(txtQtdAlunos.Text)
                    );
                    modalidade.alterarModalidade();
                    limparTelaPesquisa();
                    groupBox1.Visible = false;
                    MessageBox.Show("Turma atualizada com Sucesso!", "Sucesso!");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Dê um preço adequado para a modalidade!","Erro");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void limparTelaPesquisa()
        {
            txtDescricao.Text = "";
            txtId.Text = "";
            txtPreco.Text = "";
            txtQtdAlunos.Text = "";
            txtQtdAulas.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                idModalidade = Convert.ToInt32(txtId.Text.ToString());

                Modalidades modalidade = new Modalidades(idModalidade);
                DialogResult dialogResult = MessageBox.Show("Deseja mesmo excluir essa modalidade e todas as suas turmas?", "Confirmar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (modalidade.excluirModalidade()) MessageBox.Show("Modalidade excluída com sucesso", "SUCESSO");
                        else MessageBox.Show("Essa modalidade não existe ou já foi excluida!", "ERRO");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                groupBox1.Visible = false;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Digite um ID válido!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

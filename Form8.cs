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
    public partial class Form8 : Form
    {
        Form1 parent;
        List<Modalidades> listaModalidades;
        int idTurma;
        public Form8(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            listaModalidades = Modalidades.buscaModalidades();
            foreach (Modalidades modalidade in listaModalidades)
            {
                cbbModalidades.Items.Add(modalidade.getDescricao());
            }

            cbbDiaSemana.SelectedIndex = 0;
            cbbModalidades.SelectedIndex = 0;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try {
                if (txtProfessor.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Aponte um professor para a Turma!", "Erro!");
                }
                else
                { 
                    //Caso dê erro, é porque não foi preenchido corretamente o campo de data
                    int dataEmNumero = Convert.ToInt32(txtHora.Text.ToString().Replace(":", ""));
                    if (dataEmNumero > 2359)
                    {
                        throw new FormatException();
                    }

                    Modalidades modalidade = listaModalidades[cbbModalidades.SelectedIndex];
                    int idModalidade = modalidade.getId_Modalidade();

                    idTurma = Convert.ToInt32(txtId.Text.ToString());

                    Turmas turma = new Turmas(
                        idModalidade,
                        txtProfessor.Text.Trim(),
                        cbbDiaSemana.SelectedItem.ToString(),
                        txtHora.Text.ToString()
                    );
                    turma.setId_turma(idTurma);

                    turma.alterarTurma();
                    limparTelaCadastro();
                    groupBox1.Visible = false;
                    MessageBox.Show("Turma atualizada com Sucesso!", "Sucesso!");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Insira um horário válido!");
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            
        }

        public void limparTelaCadastro()
        {
            txtProfessor.Text = "";
            txtHora.Text = "";
            cbbModalidades.SelectedIndex = 0;
            cbbDiaSemana.SelectedIndex = 0;
            txtId.Text = "";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Visible = false;
                idTurma = Convert.ToInt32(txtId.Text.ToString());
                Turmas turma = Turmas.buscaTurma(idTurma);
                if (turma != null)
                {
                    txtHora.Text = turma.getHora();
                    txtProfessor.Text = turma.getProfessor();
                    cbbDiaSemana.SelectedIndex = cbbDiaSemana.Items.IndexOf(turma.getDia_semana());

                    Modalidades modalidade = Modalidades.buscaModalidade(turma.getId_modalidade());
                    cbbModalidades.SelectedIndex = cbbModalidades.Items.IndexOf(modalidade.getDescricao());

                    groupBox1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Turma não encontrada.");
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                idTurma = Convert.ToInt32(txtId.Text.ToString());

                Turmas turma = new Turmas(idTurma);
                DialogResult dialogResult = MessageBox.Show("Deseja mesmo excluir essa turma?", "Confirmar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (turma.excluirTurma()) MessageBox.Show("Turma excluída com sucesso", "SUCESSO");
                        else MessageBox.Show("Turma não existente ou já excluida", "ERRO");
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

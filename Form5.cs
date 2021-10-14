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
    public partial class Form5 : Form
    {
        Form1 parent;
        List<Modalidades> listaModalidades;
        public Form5(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            listaModalidades = Modalidades.buscaModalidades();
            foreach (Modalidades modalidade in listaModalidades)
            {
                cbbModalidades.Items.Add(modalidade.getDescricao());
            }

            cbbDiaSemana.SelectedIndex = 0;
            cbbModalidades.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e) {
            try
            {
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

                    Modalidades modalidade = listaModalidades.Find(x => x.getDescricao().Contains(cbbModalidades.SelectedItem.ToString()));
                    int idModalidade = modalidade.getId_Modalidade();

                    Turmas turma = new Turmas(
                        idModalidade,
                        txtProfessor.Text.Trim(),
                        cbbDiaSemana.SelectedItem.ToString(),
                        txtHora.Text.ToString()
                    );
                    turma.cadastrarTurma();
                    limparTelaCadastro();
                    MessageBox.Show("Turma cadastrada com Sucesso!", "Sucesso!");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Insira um horário válido!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void limparTelaCadastro() {
            txtProfessor.Text = "";
            txtHora.Text = "";
            cbbModalidades.SelectedIndex = 0;
            cbbDiaSemana.SelectedIndex = 0;

        }
    }
}

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

        public void carregarModalidades()
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            listaModalidades = Modalidades.buscaModalidade();
            foreach (Modalidades modalidade in listaModalidades)
            {
                cbbModalidades.Items.Add(modalidade.getDescricao());
            }

            cbbDiaSemana.SelectedIndex = 0;
            cbbModalidades.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (txtProfessor.Text.Trim().Equals(""))
            {
                MessageBox.Show("Aponte um professor para a Turma!","Erro!");
            }
            else
            {
                Turmas turma = new Turmas(
                    cbbModalidades.SelectedIndex + 1,
                    txtProfessor.Text.Trim(),
                    cbbDiaSemana.SelectedItem.ToString(),
                    txtHora.Text.ToString()
                );
                turma.cadastrarTurma();
                limparTelaCadastro();
                MessageBox.Show("Turma cadastrada com Sucesso!","Sucesso!");
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

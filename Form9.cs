using MySql.Data.MySqlClient;
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
    public partial class Form9 : Form
    {
        Form1 parent;
        List<Modalidades> listaModalidades;
        List<Turmas> listaTurmas;

        public Form9(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gpbTurmas.Visible = false;
            dgvTurmas.Rows.Clear();

            listaTurmas = Turmas.buscaTurmas(listaModalidades[cbbModalidades.SelectedIndex].getId_Modalidade());
            foreach (Turmas turma in listaTurmas)
            {
                dgvTurmas.Rows.Add(turma.getId_turma(),turma.getProfessor(), turma.getDia_semana(),turma.getHora());
            }

            gpbTurmas.Visible = true;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            listaModalidades = Modalidades.buscaModalidades();
            foreach (Modalidades modalidade in listaModalidades)
            {
                cbbModalidades.Items.Add(modalidade.getDescricao());
            }

            cbbModalidades.SelectedIndex = 0;
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {

            DateTime today = DateTime.Today.Date;
            try
            {
                Aluno al = new Aluno(txtCPF.Text);
                if (!al.consultaAluno())
                {
                    MessageBox.Show("Não existe aluno cadastrado com esse CPF!");
                    return;
                }
                int linha = dgvTurmas.SelectedCells[0].RowIndex;
                int idTurma = int.Parse(dgvTurmas.Rows[linha].Cells[0].Value.ToString());
                Matricula ma = new Matricula(idTurma, al.getCPF(), today, 1);
                ma.cadastroMatricula();
                MessageBox.Show("Cadastrado com sucesso!", "Sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

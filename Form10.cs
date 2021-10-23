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
    public partial class Form10 : Form
    {
        Form1 parent;
        List<Matricula> listaMatriculas;
        string cpf;

        public Form10(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnMatriculas_Click(object sender, EventArgs e)
        {
            cpf = txtCPF.Text;
            fillDataGrid();
        }

        private void fillDataGrid()
        {
            try
            {
                gpbMatriculas.Visible = false;
                Matricula ma = new Matricula(cpf);

                listaMatriculas = ma.consultaMatriculas();
                dgvMatriculas.Rows.Clear();

                foreach (Matricula matricula in listaMatriculas)
                {
                    dgvMatriculas.Rows.Add(matricula.getId_turma(), matricula.getData_entrada().Date.ToString("d"));
                }

                gpbMatriculas.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerTurma_Click(object sender, EventArgs e)
        {
            int linha = dgvMatriculas.SelectedCells[0].RowIndex;
            int idTurma = int.Parse(dgvMatriculas.Rows[linha].Cells[0].Value.ToString());

            Turmas turma = Turmas.buscaTurma(idTurma);
            
            MessageBox.Show($"ID Turma: {turma.getId_turma().ToString()}\n" +
                $"ID modalidade: {turma.getId_modalidade().ToString()}\n" +
                $"Professor: {turma.getProfessor()}\n" +
                $"Dia da Semana: {turma.getDia_semana()}\n" +
                $"Hora: {turma.getHora()}"
                ,"Dados da Turma");
        }

        private void btnExcluirMatricula_Click(object sender, EventArgs e)
        {
            try
            {
                int linha = dgvMatriculas.SelectedCells[0].RowIndex;
                int idTurma = int.Parse(dgvMatriculas.Rows[linha].Cells[0].Value.ToString());

                Matricula ma = new Matricula(idTurma,cpf);

                if (ma.excluirMatricula())
                {
                    MessageBox.Show("Matrícula excluída!", "Sucesso!");
                    fillDataGrid();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menuStrip1.Enabled = false;
            DAO_Conexao.getConexao("143.106.241.3", "cl19118", "cl19118", "192103");
            Form2 form2 = new Form2(this);
            form2.MdiParent = this;
            form2.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.MdiParent = this;
            form3.Show();
        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.MdiParent = this;
            form4.Show();
        }

        private void pesquisarTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.MdiParent = this;
            form5.Show();
        }

        private void verModalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this);
            form6.MdiParent = this;
            form6.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(this);
            form8.MdiParent = this;
            form8.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(this);
            form7.MdiParent = this;
            form7.Show();
        }
    }
}

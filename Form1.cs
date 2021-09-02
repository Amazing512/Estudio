﻿using System;
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
    }
}

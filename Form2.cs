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
    public partial class Form2 : Form
    {
        string user, password;
        Form1 parent;

        public Form2(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user = "admin";
            password = "admin";
            int tipo = DAO_Conexao.login(user, password);
            if (tipo == 1)
            {
                this.Close();

                Form[] children = parent.MdiChildren;
                foreach (Form child in children)
                {
                    if (child.Name.Equals("Form3")) child.Show();
                }

                Control[] menuStrip = parent.Controls.Find("menuStrip1", false);
                menuStrip[0].Enabled = true;
            }
            else if (tipo == 0)
            {
                MessageBox.Show("O usuário ou a senha estão incorretas");
                textBox1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = textBox1.Text.Trim();
            password = textBox2.Text.Trim();
            int tipo = DAO_Conexao.login(user, password);
            if (tipo == 1)
            {
                this.Close();
                
                Form[] children = parent.MdiChildren;
                foreach(Form child in children)
                {
                    if (child.Name.Equals("Form3")) child.Show();
                }

                Control[] menuStrip = parent.Controls.Find("menuStrip1", false);
                menuStrip[0].Enabled = true;
            }
            else if(tipo == 0)
            {
                MessageBox.Show("O usuário ou a senha estão incorretas");
                textBox1.Focus();
            }
        }
    }
}

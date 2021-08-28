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
            if (DAO_Conexao.getConexao("143.106.241.3", "cl19118", "cl19118", "192103"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de conexão");
            Form2 form2 = new Form2(this);
            form2.MdiParent = this;
            form2.Show();

            Form3 form3 = new Form3();
            form3.MdiParent = this;

            Aluno a;
            try
            {
                a = new Aluno();
                a.setCPF("111.111.111-11");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                //MessageBox.Show(ex.ToString());
            }
        }
    }
}

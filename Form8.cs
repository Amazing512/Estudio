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
        public Form8(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
    }
}

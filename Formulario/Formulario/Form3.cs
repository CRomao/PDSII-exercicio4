using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form3 : Form
    {
        public Form3(string usuario)
        {
            InitializeComponent();

            label3.Text = usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

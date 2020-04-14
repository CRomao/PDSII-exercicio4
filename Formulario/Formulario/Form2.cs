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
    public partial class Form2 : Form
    {
        Form1 login;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            login = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Equals(""))
            {
                MessageBox.Show("Preencha o usuário!",
                    "Mensagem do Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }else if (tbSenha.Text.Equals(""))
            {
                MessageBox.Show("Preencha a senha!",
                    "Mensagem do Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                cadastrarUsuario();
            }
        }

        public void cadastrarUsuario()
        {
            login.usuario = new Usuario(tbUsuario.Text, tbSenha.Text);
            MessageBox.Show("Usuário cadastrado com sucesso!",
                        "Mensagem do Sistema", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

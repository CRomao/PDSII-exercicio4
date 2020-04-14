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
    public partial class Form1 : Form
    {

        public Usuario usuario = null;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            if (usuario != null)
            {
                if (tbLogin.Text == usuario.getUsuario() && tbSenha.Text == usuario.getSenha())
                {
                    MessageBox.Show("Login realizado com sucesso!",
                        "Mensagem do Sistema", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    chamarTelaPrincipal();
                }
                else
                {
                    MessageBox.Show("Login ou senha inválido!",
                        "Mensagem do Sistema", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Login ou senha inválido!\n\nCaso não tenha um cadastro, pode fazer\nno botão cadastrar.",
                    "Mensagem do Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void cadastrar()
        {
            Form2 form2 = new Form2(this);
            form2.Show();
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cadastrar();
        }

        public void chamarTelaPrincipal()
        {
            Form3 principal = new Form3(usuario.getUsuario());
            principal.Show();
            
        }
    }
}

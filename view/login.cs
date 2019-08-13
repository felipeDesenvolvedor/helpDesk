using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace view
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }

        ControllerLogin logar = new ControllerLogin();
        //ControllerFuncionario funcionario = new ControllerFuncionario();
        ArrayList usuarios = new ArrayList();
        TelaMenuPrincipal menuPrincipal = new TelaMenuPrincipal();

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            usuarios = logar.controllerLogar(txtUsuario.Text, txtSenha.Text);

            int i = 0;
            while (i <= usuarios.Count - 1)
            {
                if (usuarios[i].Equals(true))
                {
                    Program.Setor = (Int32)usuarios[++i];
                    Program.nomeSetor = usuarios[++i].ToString();
                    MessageBox.Show(Program.nomeSetor);
                    menuPrincipal.Show();
                    this.Hide();
                    break;
                }
                else
                if (!usuarios[i].Equals(true))
                {
                   if (usuarios[i].Equals(logar.mensagemUsuario))
                    {
                        MessageBox.Show(usuarios[i].ToString());
                        txtUsuario.Clear();
                        txtUsuario.Select();
                        break;
                    }

                    if (usuarios[i].Equals(logar.mensagemSenha))
                    {
                        MessageBox.Show(usuarios[i].ToString());
                        txtSenha.Clear();
                        txtSenha.Select();
                        break;
                    }

                }
                i++;
            }
        }
    }
}

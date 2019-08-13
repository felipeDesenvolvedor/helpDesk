using System;
using System.Collections.Generic;
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
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        Usuario formUsuario = new Usuario();
        DataTable tabela = new DataTable();
        ControllerUsuario contr = new ControllerUsuario();
        public string usuario, senha, funcionario;
        public int codUsuario;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            tabela = contr.consultarUsuario();
            usuario = txtUsuarioEditar.Text;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            formUsuario.preecherTabela();
            formUsuario.Show();
        }

        private void btnRedefinirSenha_Click(object sender, EventArgs e)
        {
            senha = "mudar1234";
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            bool retorno;

            retorno = contr.validarUsuarios(tabela, txtUsuarioEditar.Text);

            if (retorno.Equals(true))
            {
                MessageBox.Show("Usuario Ja Cadastrado");
                txtUsuarioEditar.Clear();
                txtUsuarioEditar.Select();
                return;
            }

            int resultado = contr.editarUsuarioController(codUsuario, txtUsuarioEditar.Text, senha);

            if (resultado == 1)
            {
                MessageBox.Show("Usuario alterado com sucesso");
            }
            else
            {
                MessageBox.Show("Usuario não alterado");
            }
        }
    }
}

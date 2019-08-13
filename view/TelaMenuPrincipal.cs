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
    public partial class TelaMenuPrincipal : Form
    {
        public TelaMenuPrincipal()
        {
            InitializeComponent();
        }

        

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario telaUsuario = new Usuario();
            telaUsuario.Show();
            Hide();
        }

      
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarFuncionario funcionarios = new EditarFuncionario();
            funcionarios.Show();
            Hide();
        }

        public void TelaMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + ": " + Program.nomeSetor;


            if (!Program.Setor.Equals(1))
            {
                usuarioToolStripMenuItem.Enabled = false;
                funcionariosToolStripMenuItem.Enabled = false;
            }

            if (Program.Setor.Equals(2))
            {
                editarToolStripMenuItem.Enabled = false;
                fecharToolStripMenuItem.Enabled = false;
            }

            if (Program.Setor.Equals(3))
            {
                clientesToolStripMenuItem.Enabled = false;
                abrirToolStripMenuItem.Enabled = false;
                editarToolStripMenuItem.Enabled = false;
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirOS formOS = new AbrirOS();
            Hide();
            formOS.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarOS editarOS = new EditarOS();
            Hide();
            editarOS.Show();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharOS fecharOS = new FecharOS();
            fecharOS.Show();
            Hide();
            
        }

        private void cadastrarPessoaFísicaToolStripMenuItem_Click_Click(object sender, EventArgs e)
        {
            ClientePF telapf = new ClientePF();
            telapf.Show();
            this.Hide();
        }

        private void cadastroDePessoaJurídicaToolStripMenuItem_Click_Click(object sender, EventArgs e)
        {
            ClientePJ telpj = new ClientePJ();
            telpj.Show();
            this.Hide();
        }
    }
}

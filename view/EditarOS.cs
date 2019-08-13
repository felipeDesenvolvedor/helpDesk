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
    public partial class EditarOS : Form
    {
        public EditarOS()
        {
            InitializeComponent();
        }

        DataTable listaOS = new DataTable();
        ControllerOS OS = new ControllerOS();

        public void preencherGridOS()
        {
            listaOS = OS.consultarOsController();
            gridEditarOS.DataSource = listaOS;
            gridEditarOS.Rows[0].Selected = false;
        }

        private void EditarOS_Load(object sender, EventArgs e)
        {
            preencherGridOS();
            gridEditarOS.Rows[0].Selected = false;
            txtCodTecnico.Enabled = false;
            comboPrioridade.Enabled = false;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaMenuPrincipal menu = new TelaMenuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

            int i = 0;
            while (i <= listaOS.Rows.Count - 1)
            {
                gridEditarOS.Rows[i].Selected = false;
                //MessageBox.Show(listaOS.Rows[i]["Codigo"].ToString().GetType().ToString());
                //MessageBox.Show(listaOS.Rows[i]["Prioridade"].ToString());
                if (listaOS.Rows[i]["Codigo"].ToString() == txtSelecionarOS.Text)
                {
                    //MessageBox.Show(listaOS.Rows[i]["Codigo"].ToString());
                    txtCodTecnico.Enabled = true;
                    txtCodTecnico.Text = listaOS.Rows[i]["Codigo_Tecnico"].ToString();

                    comboPrioridade.Enabled = true;

                    gridEditarOS.Rows[i].Selected = true;
                }
                //MessageBox.Show(listaOS.Rows[i]["Codigo"].ToString());
                i++;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //if (txtSelecionarOS.Text.Equals(string.Empty))
            //{
            //    MessageBox.Show("Campo de OS em branco");
            //    txtSelecionarOS.Clear();
            //    txtSelecionarOS.Select();
            //    return;
            //}

            //if (txtCodTecnico.Text.Equals(string.Empty))
            //{
            //    MessageBox.Show("Campo de tecnico em branco");
            //    txtCodTecnico.Clear();
            //    txtCodTecnico.Select();
            //    return;
            //}

            int retorno;
            int OsSelecionada = int.Parse(txtSelecionarOS.Text);
            int tecnicoSelecionado = int.Parse(txtCodTecnico.Text);
            MessageBox.Show(comboPrioridade.SelectedItem.ToString());

            retorno = OS.editarOS(OsSelecionada, tecnicoSelecionado, comboPrioridade.SelectedItem.ToString());
            preencherGridOS();

            if (retorno.Equals(1))
            {
                MessageBox.Show("Alterado com sucesso");
                txtSelecionarOS.Clear();
                txtCodTecnico.Clear();

            }
        }
    }
}

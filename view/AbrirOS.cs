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
using model;

namespace view
{
    public partial class AbrirOS : Form
    {
        // categorias equipamentos; impressao, desktop, e movel
        public AbrirOS()
        {
            InitializeComponent();
        }

       
        DataTable funcionarios = new DataTable();
        DataTable clientes = new DataTable();

        int codTecnico;
        int codCliente;
        int retorno;
        string nomeTecnico;
        string nomeCliente;
        string tipoCliente;
        string data;

        private void AbrirOS_Load(object sender, EventArgs e)
        {
            CarregarTabelas carregarTabelas = new CarregarTabelas();
            funcionarios = carregarTabelas.carregarADM();
            clientes = carregarTabelas.carregarClientes();
        }

       private void btnAbrir_Click(object sender, EventArgs e)
        {
            Boolean tecnicoEncontrado = false;
            Boolean clienteEncontrado = false;

            if (comboTipoCliente.SelectedItem == null || comboTipoCliente.SelectedItem == string.Empty)
            {

                MessageBox.Show("Selecione o tipo de cliente");
                comboTipoCliente.Select();
                return;
            }
            

            if (comboPrioridade.SelectedItem == null || comboPrioridade.SelectedItem == string.Empty)
            {

                MessageBox.Show("selecione uma Prioridade");
                comboTipoCliente.Select();
                return;
            }

           
            if (comboCategoria.SelectedItem == null || comboCategoria.SelectedItem == string.Empty)
            {

                MessageBox.Show("selecione uma Categoria de Equipamento");
                comboTipoCliente.Select();
                return;
            }

            if (descricaoOS.Text.Equals("")) {
                MessageBox.Show("Adicione uma descrição !!");
                descricaoOS.Select();
                return;
            }

            int i = 0;
            while (i <= funcionarios.Rows.Count - 1)
            {
                if (funcionarios.Rows[i]["Setor"].ToString().Equals("Técnico"))
                {
                    if (funcionarios.Rows[i]["Código"].ToString() == txtCodTecnico.Text)
                    {
                        codTecnico = int.Parse(txtCodTecnico.Text);
                        nomeTecnico = funcionarios.Rows[i]["Nome"].ToString();
                        tecnicoEncontrado = true;
                    }

                }
                i++;
            }

            i = 0;
            while (i <= clientes.Rows.Count - 1)
            {

                if (clientes.Rows[i]["Código"].ToString() == txtCodCliente.Text)
                {
                    codCliente = int.Parse(txtCodCliente.Text);
                    nomeCliente = clientes.Rows[i]["Nome"].ToString();
                    clienteEncontrado = true;
                }

                i++;
            }

            if (tecnicoEncontrado.Equals(false))
            {
                MessageBox.Show("Técnico não cadastrado !!");
                txtCodTecnico.Clear();
                txtCodTecnico.Select();
                return;
            }

            if (clienteEncontrado.Equals(false))
            {
                MessageBox.Show("Cliente não cadastrado !!");
                txtCodTecnico.Clear();
                txtCodTecnico.Select();
                return;
            }


            ControllerOS OS = new ControllerOS();
            retorno = OS.abrirOSController(DateTime.Now.ToShortDateString(), comboPrioridade.SelectedItem.ToString(), "aberta", nomeTecnico, nomeCliente, descricaoOS.Text, comboCategoria.SelectedItem.ToString(), codTecnico, codCliente, comboTipoCliente.SelectedItem.ToString());

            if (retorno.Equals(1))
            {
                MessageBox.Show("OS aberta com sucesso");
            }
            else { MessageBox.Show("Erro na abertura da OS, consulte um administrador !!!"); }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaMenuPrincipal menu = new TelaMenuPrincipal();
            menu.Show();
            this.Hide();
        }
    }
}

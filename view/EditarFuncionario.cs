using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;
using Controller;

namespace view
{
    public partial class EditarFuncionario : Form
    {
        public EditarFuncionario()
        {
            InitializeComponent();
        }

        ControllerADM contrADM = new ControllerADM();
        ControllerAtendente contrAtendente = new ControllerAtendente();
        ControllerTecnico contrTecnico = new ControllerTecnico();

        CarregarTabelas registrosFuncionarios = new CarregarTabelas();
        DataTable tabela = new DataTable();
        TelaMenuPrincipal menuPrincipal = new TelaMenuPrincipal();
        int codSelecionado;
        int funcionarioSelecionado;
        string setorSelecionado;

        public void preecherTabela()
        {
          tabela = registrosFuncionarios.carregarADM();
          dataGridFuncionarios.DataSource = tabela;
        }

        private void EditarFuncionario_Load(object sender, EventArgs e)
        {
            preecherTabela();
            dataGridFuncionarios.ClearSelection();
            txtConsultarFuncionario.Select();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtConsultarFuncionario.Text == string.Empty)
            {
                MessageBox.Show("Campo Em Branco");
                txtConsultarFuncionario.Select();
                return;
            }

            
            int i = 0;
            Boolean usuarioEncontrado = false;
          
            while (i <= tabela.Rows.Count - 1)
            {
                dataGridFuncionarios.ClearSelection();

                if (tabela.Rows[i]["Código"].ToString() == txtConsultarFuncionario.Text)
                {
                    usuarioEncontrado = true;
                    dataGridFuncionarios.Rows[i].Selected = true;

                    txtConsultarFuncionario.Clear();

                    txtFuncionario.Text = dataGridFuncionarios.Rows[i].Cells["Nome"].Value.ToString();
                    funcionarioSelecionado = (Int32)dataGridFuncionarios.Rows[i].Cells["Código"].Value;
                    setorSelecionado = dataGridFuncionarios.Rows[i].Cells["Setor"].Value.ToString();

                    //codSelecionado = (Int32)dataGridFuncionarios.Rows[i].Cells["Código"].Value;
                    return;
                }

                else if (tabela.Rows[i]["Nome"].ToString() == txtConsultarFuncionario.Text)
                {
                    usuarioEncontrado = true;
                    dataGridFuncionarios.Rows[i].Selected = true;

                    txtConsultarFuncionario.Clear();

                    txtFuncionario.Text = dataGridFuncionarios.Rows[i].Cells["Nome"].Value.ToString();
                    funcionarioSelecionado = (Int32)dataGridFuncionarios.Rows[i].Cells["Código"].Value;
                    setorSelecionado = dataGridFuncionarios.Rows[i].Cells["Setor"].Value.ToString();

                    return;
                }
                else
                {
                    usuarioEncontrado = false;
                }
                i++;
            }

            if (usuarioEncontrado.Equals(false))
            {
                MessageBox.Show("Usuario não cadastrado.");
                txtConsultarFuncionario.Clear();
                txtConsultarFuncionario.Select();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int retorno;
            if (setorSelecionado.Equals("Administrativo"))
            {
              
              retorno = contrADM.editarAdmController(funcionarioSelecionado, txtFuncionario.Text);

                if (retorno.Equals(1))
                {
                    MessageBox.Show("Funcionario Editado");
                    preecherTabela();
                }  
            }

            else if (setorSelecionado.Equals("Atendimento"))
            {

               retorno = contrAtendente.editarAtendenteController(funcionarioSelecionado, txtFuncionario.Text);

                if (retorno.Equals(1))
                {
                    MessageBox.Show("Funcionario Editado");
                    preecherTabela();
                }
            }

            else if (setorSelecionado.Equals("Técnico"))
            {
                retorno = contrTecnico.editarTecnicoController(funcionarioSelecionado, txtFuncionario.Text);

                if (retorno.Equals(1))
                {
                    MessageBox.Show("Funcionario Editado");
                    preecherTabela();
                }
            }
        }
    }
}

using Controller;
using model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        DataTable tabela = new DataTable();
        DataTable Usuarios = new DataTable();

        ControllerUsuario contr = new ControllerUsuario();
        ControllerADM contrADM = new ControllerADM();
        ControllerTecnico contrTecnico = new ControllerTecnico();
        ControllerAtendente contrAtendente = new ControllerAtendente();

        CarregarTabelas registrosUsuarios = new CarregarTabelas();

        //string usuarioSelecionado, senhaSelecionada;
        int codSelecionado;
        string usuarioSelecionado = "";
        string senhaSelecionada = "";
        string funcinarioSelecionado = "";
        string setorSelecionado = "";

        int codUsuario;

        public void preecherTabela()
        {
            tabela = registrosUsuarios.carregarUsuariosFuncionarios();
            dataGridUsuario.DataSource = tabela;
            dataGridUsuario.Rows[0].Selected = false;
        }

        public void preecherUsuarios()
        {
            Usuarios = registrosUsuarios.carregarUsuarios();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            preecherTabela();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Usuario Em Branco");
                txtUsuario.Select();
                return;
            }


            if (txtFuncionario.Text == string.Empty)
            {
                MessageBox.Show("Funcionario Em Branco");
                txtFuncionario.Select();
                return;
            }

            if (comboSetor.SelectedItem == null || comboSetor.SelectedItem == string.Empty) 
            {
                MessageBox.Show("Setor não selecionado !!");    
                return;
            }


            int i = 0;
            while (i <= tabela.Rows.Count - 1)
            {
                if (tabela.Rows[i]["Usuario"].ToString() == txtUsuario.Text)
                {
                    MessageBox.Show("Usuario Ja Cadastrado");
                    txtUsuario.Clear();
                    txtUsuario.Select();
                    return;
                }

                if (tabela.Rows[i]["Funcionario"].ToString() == txtFuncionario.Text && tabela.Rows[i]["Usuario"].ToString() == txtUsuario.Text)
                {
                    MessageBox.Show("Esse funcionario ja tem usuario");
                    txtFuncionario.Clear();
                    txtUsuario.Clear();
                    comboSetor.SelectedIndex = 0;
                    return;
                }

                i++;
            }

            MessageBox.Show("Usuario Cadastrado");
            contr.gravarUsuarioController(txtUsuario.Text);
            preecherUsuarios();
                      
            codUsuario = percorrerTabela(txtUsuario.Text);
            txtUsuario.Clear();
                       
            //Cadastro de funcionario de acordo com o setor
            int selecionado = comboSetor.SelectedIndex;

            //Administrativo
            if (selecionado == 1)
            {
                contrADM.gravarAdmController(txtFuncionario.Text, 1, codUsuario);
                preecherTabela();
                txtFuncionario.Clear();
                comboSetor.SelectedIndex = 0;
            }

            //Atendimento
            if (selecionado == 2)
            {
                contrAtendente.gravarAtendenteController(txtFuncionario.Text, 2, codUsuario);
                preecherTabela();
                txtFuncionario.Clear();
                comboSetor.SelectedIndex = 0;
            }

            //Tecnico
            if (selecionado == 3)
            {
                contrTecnico.gravarTecnicoController(txtFuncionario.Text, 3, codUsuario);
                preecherTabela();
                txtFuncionario.Clear();
                comboSetor.SelectedIndex = 0;
            }
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaMenuPrincipal menu = new TelaMenuPrincipal();
            this.Hide();
            menu.Show();
        }

        public int percorrerTabela(string coluna)
        {
            int retorno = 0;
            int i = 0;
           
            while (i <= Usuarios.Rows.Count - 1)
            {

                if (Usuarios.Rows[i]["usuario"].ToString() == coluna.ToString())
                {
                    retorno = (Int32)Usuarios.Rows[i]["codUsuario"];
                }
                i++;
            }

            return retorno;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            usuarioSelecionado = "";
            funcinarioSelecionado = "";
            setorSelecionado = "";


            if (txtConsultarUsuario.Text == string.Empty)
            {
                MessageBox.Show("Campo Em Branco");
                txtConsultarUsuario.Select();
                return;
            }


            int i = 0;
            Boolean usuarioEncontrado = false;
            while (i <= tabela.Rows.Count - 1)
            {
                dataGridUsuario.ClearSelection();

                if (tabela.Rows[i]["Usuario"].ToString() == txtConsultarUsuario.Text)
                {
                    usuarioEncontrado = true;

                    dataGridUsuario.Rows[i].Selected = true;

                    codSelecionado = (Int32)dataGridUsuario.Rows[i].Cells["Codigo"].Value;
                    usuarioSelecionado = txtConsultarUsuario.Text;
                    senhaSelecionada = dataGridUsuario.Rows[i].Cells["Senha"].Value.ToString();
                    setorSelecionado = dataGridUsuario.Rows[i].Cells["Setor"].Value.ToString();
                    return;
                }

                else if (tabela.Rows[i]["Codigo"].ToString() == txtConsultarUsuario.Text)
                {
                    usuarioEncontrado = true;

                    dataGridUsuario.Rows[i].Selected = true;

                    codSelecionado = (Int32)dataGridUsuario.Rows[i].Cells["Codigo"].Value;
                    usuarioSelecionado = dataGridUsuario.Rows[i].Cells["Usuario"].Value.ToString();
                    senhaSelecionada = dataGridUsuario.Rows[i].Cells["Senha"].Value.ToString();
                    setorSelecionado = dataGridUsuario.Rows[i].Cells["Setor"].Value.ToString();
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
                txtConsultarUsuario.Clear();
                txtConsultarUsuario.Select();
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {

            EditarUsuario edicaoUsuario = new EditarUsuario();

            if (usuarioSelecionado == string.Empty)
            {
                MessageBox.Show("Usuario não selecionado");
                txtConsultarUsuario.Select();
                return;
            }


            edicaoUsuario.codUsuario = codSelecionado;
            edicaoUsuario.txtUsuarioEditar.Text = usuarioSelecionado;
            edicaoUsuario.senha = senhaSelecionada;
            edicaoUsuario.Show();
            this.Hide();


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int retorno;

            if (codSelecionado == 0 || setorSelecionado.Equals(""))
            {
                MessageBox.Show("Usuario não selecionado");
                txtConsultarUsuario.Clear();
                txtConsultarUsuario.Select();
                return;
            }

            retorno = contr.excluirUsuarioController(codSelecionado, setorSelecionado);
            preecherUsuarios();
            preecherTabela();

           
            MessageBox.Show("Usuario excluido com sucesso");
            txtConsultarUsuario.Clear();
         }
    }
}

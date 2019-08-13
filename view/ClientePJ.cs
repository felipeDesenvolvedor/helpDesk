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
    public partial class ClientePJ : Form
    {
        public ClientePJ()
        {
            InitializeComponent();
        }

        private void ClientePJ_Load(object sender, EventArgs e)
        {
            preccherPj();
            preecherTabela();

        }
        public void preecherTabela()
        {
            tabela = ClientesPj.carregarClientePjend();
            Dgvpj.DataSource = tabela;

        }

        public void preccherPj()
        {
            pessoaJur = ClientesPj.carregarClientepj();
        }
        string Clienteselecionado = "";
   
        int id = 0;

        string tipoCliente = "Pessoa Jurídica";



        DataTable tabela = new DataTable();
        ControllerPJ contr = new ControllerPJ();
        ControllerEnderecoPJ contrendpj = new ControllerEnderecoPJ();
        CarregarTabelas ClientesPj = new CarregarTabelas();
        DataTable pessoaJur = new DataTable();
        TelaMenuPrincipal tela = new TelaMenuPrincipal();

        private void Btngravar_Click(object sender, EventArgs e)
        {
            if (Txtrazao.Text == string.Empty || Txtcnp.Text == string.Empty
                || Txtemail.Text == string.Empty || Txttelefone.Text == string.Empty
                || Txtlogradouro.Text == string.Empty || Txtnumero.Text == string.Empty || Txtcep.Text == string.Empty
                || Txtbairro.Text == string.Empty || Txtestado.Text == string.Empty || Txtcidade.Text == string.Empty)
            {

                MessageBox.Show("Verifique os campos obrigatórios");
                return;


            }

            if (Txtid.Text == string.Empty)
            {

                int i = 0;
                while (i <= tabela.Rows.Count - 1)
                {
                    if (tabela.Rows[i]["Cnpj"].ToString() == Txtcnp.Text)
                    {
                        MessageBox.Show("Cliente já possui cadastro");

                        Txtcnp.Clear();
                        Txtcnp.Select();

                        return;
                    }


                    i++;

                }
                string cnpj = Txtcnp.Text;

                contr.gravarClientepfController(Txtrazao.Text,Txtcnp.Text, Txtemail.Text, Txttelefone.Text, Txtcel.Text,tipoCliente);



                preccherPj();

                int j = 0;
                while (j <= pessoaJur.Rows.Count - 1)
                {
                    if (pessoaJur.Rows[j]["Cnpj"].ToString() == cnpj)
                    {

                        id = (Int32)pessoaJur.Rows[j]["Código"];

                        contrendpj.gravarUsuarioController(Txtlogradouro.Text, Txtcep.Text, Txtbairro.Text, Txtestado.Text, Txtcidade.Text, Txtnumero.Text, id);
                        Txtid.Clear();
                        Txtrazao.Clear();
                        Txtcnp.Clear();
                        Txtemail.Clear();
                        Txttelefone.Clear();
                        Txtcel.Clear();
                        Txtlogradouro.Clear();
                        Txtnumero.Clear();
                        Txtcep.Clear();
                        Txtbairro.Clear();
                        Txtestado.Clear();
                        Txtcidade.Clear();
                        MessageBox.Show("Cliente Cadastrado com sucesso");
                        preecherTabela();
                        return;

                    }
                    j++;
                }



            }
            else
            {
                id = int.Parse(Txtid.Text);
                contr.editarClientepfController( Txtrazao.Text,Txtcnp.Text, Txtemail.Text, Txttelefone.Text, Txtcel.Text,Txtid.Text);
                contrendpj.editarUsuarioController(Txtlogradouro.Text, Txtcep.Text, Txtbairro.Text, Txtestado.Text, Txtcidade.Text, Txtnumero.Text, id);
                Txtid.Clear();
                Txtrazao.Clear();
                Txtcnp.Clear();
                Txtemail.Clear();
                Txttelefone.Clear();
                Txtcel.Clear();
                Txtlogradouro.Clear();
                Txtnumero.Clear();
                Txtcep.Clear();
                Txtbairro.Clear();
                Txtestado.Clear();
                Txtcidade.Clear();
                Btnexcluir.Enabled = false;
                preecherTabela();

                MessageBox.Show("Cliente alterado com sucesso");

            }



        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            Txtid.Clear();
            Txtrazao.Clear();
            Txtcnp.Clear();
            Txtemail.Clear();
            Txttelefone.Clear();
            Txtcel.Clear();
            Txtlogradouro.Clear();
            Txtnumero.Clear();
            Txtcep.Clear();
            Txtbairro.Clear();
            Txtestado.Clear();
            Txtcidade.Clear();

            Btnexcluir.Enabled = false;
        }

        private void Btnexcluir_Click(object sender, EventArgs e)
        {
            int retorno;
            int retorno2;
            if (Txtid.Text == string.Empty)
            {
                MessageBox.Show("Não há cliente selecionado");
                Btnexcluir.Enabled = false;
            }
            //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão e comparar o botão apertado
            else if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                retorno2 = contrendpj.excluirUsuarioController(Txtid.Text);

                retorno = contr.excluirClientepfController(Txtid.Text);
                preecherTabela();

                Txtid.Clear();
                Txtrazao.Clear();
                Txtcnp.Clear();
                Txtemail.Clear();
                Txttelefone.Clear();
                Txtcel.Clear();
                Txtlogradouro.Clear();
                Txtnumero.Clear();
                Txtcep.Clear();
                Txtbairro.Clear();
                Txtestado.Clear();
                Txtcidade.Clear();
                Btnexcluir.Enabled = false;

                //Sua rotina de exclusão
                //Confirmando exclusão para o usuário
                MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Btnsele_Click(object sender, EventArgs e)
        {


            Clienteselecionado = "";


            if (ConsultPj.Text == string.Empty)
            {
                MessageBox.Show("Campo Em Branco");
                ConsultPj.Select();
                return;
            }



            int i = 0;
            Boolean Clienteencontrado = false;
            while (i <= tabela.Rows.Count - 1)
            {
                Dgvpj.ClearSelection();
                if (tabela.Rows[i]["Cnpj"].ToString() == ConsultPj.Text)
                {
                    Clienteencontrado = true;

                    Dgvpj.Rows[i].Selected = true;
                    Clienteselecionado = ConsultPj.Text;


                    Txtrazao.Text = Dgvpj.Rows[i].Cells["RazãoSocial"].Value.ToString();
                    Txtcnp.Text = Dgvpj.Rows[i].Cells["Cnpj"].Value.ToString();
                    Txtemail.Text = Dgvpj.Rows[i].Cells["Email"].Value.ToString();
                    Txttelefone.Text = Dgvpj.Rows[i].Cells["Telefone"].Value.ToString();
                    Txtcel.Text = Dgvpj.Rows[i].Cells["Celular"].Value.ToString();
                    Txtid.Text = Dgvpj.Rows[i].Cells["Código"].Value.ToString();
                    Txtlogradouro.Text = Dgvpj.Rows[i].Cells["Logradouro"].Value.ToString();
                    Txtnumero.Text = Dgvpj.Rows[i].Cells["Número"].Value.ToString();
                    Txtcep.Text = Dgvpj.Rows[i].Cells["Cep"].Value.ToString();
                    Txtbairro.Text = Dgvpj.Rows[i].Cells["Bairro"].Value.ToString();
                    Txtestado.Text = Dgvpj.Rows[i].Cells["Estado"].Value.ToString();
                    Txtcidade.Text = Dgvpj.Rows[i].Cells["Cidade"].Value.ToString();
                    Btnexcluir.Enabled = true;





                    return;
                }
                else if (tabela.Rows[i]["Código"].ToString() == ConsultPj.Text)
                {
                    Clienteencontrado = true;
                    Dgvpj.Rows[i].Selected = true;
                    Clienteselecionado = ConsultPj.Text;

                    Txtrazao.Text = Dgvpj.Rows[i].Cells["RazãoSocial"].Value.ToString();
                    Txtcnp.Text = Dgvpj.Rows[i].Cells["Cnpj"].Value.ToString();
                    Txtemail.Text = Dgvpj.Rows[i].Cells["Email"].Value.ToString();
                    Txttelefone.Text = Dgvpj.Rows[i].Cells["Telefone"].Value.ToString();
                    Txtcel.Text = Dgvpj.Rows[i].Cells["Celular"].Value.ToString();
                    Txtid.Text = Dgvpj.Rows[i].Cells["Código"].Value.ToString();
                    Txtlogradouro.Text = Dgvpj.Rows[i].Cells["Logradouro"].Value.ToString();
                    Txtnumero.Text = Dgvpj.Rows[i].Cells["Número"].Value.ToString();
                    Txtcep.Text = Dgvpj.Rows[i].Cells["Cep"].Value.ToString();
                    Txtbairro.Text = Dgvpj.Rows[i].Cells["Bairro"].Value.ToString();
                    Txtestado.Text = Dgvpj.Rows[i].Cells["Estado"].Value.ToString();
                    Txtcidade.Text = Dgvpj.Rows[i].Cells["Cidade"].Value.ToString();
                    Btnexcluir.Enabled = true;

                    return;
                }
                else
                {
                    Clienteencontrado = false;
                }
                i++;
            }


            if (Clienteencontrado.Equals(false))
            {
                MessageBox.Show("Cliente não encontrado.");
                ConsultPj.Clear();
                ConsultPj.Select();

            }
        }

        private void Btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            tela.Show();
        }
    }
}

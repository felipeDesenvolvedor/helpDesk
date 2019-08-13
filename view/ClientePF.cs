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
    public partial class ClientePF : Form
    {
        public ClientePF()
        {
            InitializeComponent();
        }
        string Clienteselecionado = "";
      
        int id = 0;
        string tipoCliente = "Pessoa física";




        DataTable tabela = new DataTable();
        ControllerPF contr = new ControllerPF();
        ControllerEnderecoPF contrendpf = new ControllerEnderecoPF();
        CarregarTabelas ClientesPf = new CarregarTabelas();
        DataTable pessoaFisica = new DataTable();
        TelaMenuPrincipal tela = new TelaMenuPrincipal();

        private void ClientePF_Load(object sender, EventArgs e)
        {
            preccherPF();
            preecherTabela();
           
        }

        public void preecherTabela()
        {
            tabela = ClientesPf.carregarClientePfend();
            Dgvpf.DataSource = tabela;
            
        }

        public void preccherPF()
        {
            pessoaFisica = ClientesPf.carregarClientepf();  
         }


        private void Btngravar_Click(object sender, EventArgs e)
        {

            if (Txtnome.Text == string.Empty || Txtsexo.Text == string.Empty || Txtcpf.Text == string.Empty
                || Txtemail.Text == string.Empty ||Txtcel.Text == string.Empty
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
                    if (tabela.Rows[i]["Cpf"].ToString() == Txtcpf.Text)
                    {
                        MessageBox.Show("Cliente já possui cadastro");

                        Txtcpf.Clear();
                        Txtcpf.Select();

                        return;
                    }
                   

                    i++;

                }
                string cpf = Txtcpf.Text;

                contr.gravarUsuarioController(Txtnome.Text, Txtsexo.Text, Txtcpf.Text, Txtemail.Text, Txttelefone.Text, Txtcel.Text,tipoCliente);


                
                preccherPF();

                int j = 0;
                while (j <= pessoaFisica.Rows.Count - 1)
                {
                    if (pessoaFisica.Rows[j]["Cpf"].ToString() == cpf)
                    {

                        id = (Int32)pessoaFisica.Rows[j]["Código"];

                        contrendpf.gravarClientepfController(Txtlogradouro.Text, Txtcep.Text, Txtbairro.Text, Txtestado.Text, Txtcidade.Text, Txtnumero.Text, id);
                        Txtid.Clear();
                        Txtnome.Clear();
                        Txtsexo.Clear();
                        Txtcpf.Clear();
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
                contr.editarUsuarioController(Txtid.Text, Txtnome.Text, Txtsexo.Text, Txtcpf.Text, Txtemail.Text, Txttelefone.Text, Txtcel.Text);
                contrendpf.editarClientepfController(Txtlogradouro.Text, Txtcep.Text, Txtbairro.Text, Txtestado.Text, Txtcidade.Text, Txtnumero.Text, id);
                Txtid.Clear();
                Txtnome.Clear();
                Txtsexo.Clear();
                Txtcpf.Clear();
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

      

        private void Btnsele_Click(object sender, EventArgs e)
        {

            Clienteselecionado = "";


            if (ConsultPf.Text == string.Empty)
            {
                MessageBox.Show("Campo Em Branco");
                ConsultPf.Select();
                return;
            }

            

            int i = 0;
            Boolean Clienteencontrado = false;
            while (i <= tabela.Rows.Count - 1)
            {
                Dgvpf.ClearSelection();
                if (tabela.Rows[i]["Cpf"].ToString() == ConsultPf.Text)
                {
                    Clienteencontrado = true;

                    Dgvpf.Rows[i].Selected = true;
                    Clienteselecionado = ConsultPf.Text;


                    Txtnome.Text = Dgvpf.Rows[i].Cells["Nome"].Value.ToString();
                    Txtsexo.Text = Dgvpf.Rows[i].Cells["sexo"].Value.ToString();
                    Txtcpf.Text = Dgvpf.Rows[i].Cells["Cpf"].Value.ToString();
                    Txtemail.Text = Dgvpf.Rows[i].Cells["Email"].Value.ToString();
                    Txttelefone.Text = Dgvpf.Rows[i].Cells["Telefone"].Value.ToString();
                    Txtcel.Text = Dgvpf.Rows[i].Cells["Celular"].Value.ToString();
                    Txtid.Text = Dgvpf.Rows[i].Cells["Código"].Value.ToString();
                    Txtlogradouro.Text = Dgvpf.Rows[i].Cells["Logradouro"].Value.ToString();
                    Txtnumero.Text = Dgvpf.Rows[i].Cells["Número"].Value.ToString();
                    Txtcep.Text = Dgvpf.Rows[i].Cells["Cep"].Value.ToString();
                    Txtbairro.Text = Dgvpf.Rows[i].Cells["Bairro"].Value.ToString();
                    Txtestado.Text = Dgvpf.Rows[i].Cells["Estado"].Value.ToString();
                    Txtcidade.Text = Dgvpf.Rows[i].Cells["Cidade"].Value.ToString();
                    Btnexcluir.Enabled = true;





                    return;
                }
                else if (tabela.Rows[i]["Código"].ToString() == ConsultPf.Text)
                {
                    Clienteencontrado = true;
                    Dgvpf.Rows[i].Selected = true;
                    Clienteselecionado = ConsultPf.Text;

                    Txtid.Text = Dgvpf.Rows[i].Cells["Código"].Value.ToString();
                    Txtnome.Text = Dgvpf.Rows[i].Cells["Nome"].Value.ToString();
                    Txtsexo.Text = Dgvpf.Rows[i].Cells["sexo"].Value.ToString();
                    Txtcpf.Text = Dgvpf.Rows[i].Cells["Cpf"].Value.ToString();
                    Txtemail.Text = Dgvpf.Rows[i].Cells["Email"].Value.ToString();
                    Txttelefone.Text = Dgvpf.Rows[i].Cells["Telefone"].Value.ToString();
                    Txtcel.Text = Dgvpf.Rows[i].Cells["Celular"].Value.ToString();
                    Txtlogradouro.Text = Dgvpf.Rows[i].Cells["Logradouro"].Value.ToString();
                    Txtnumero.Text = Dgvpf.Rows[i].Cells["Número"].Value.ToString();
                    Txtcep.Text = Dgvpf.Rows[i].Cells["Cep"].Value.ToString();
                    Txtbairro.Text = Dgvpf.Rows[i].Cells["Bairro"].Value.ToString();
                    Txtestado.Text = Dgvpf.Rows[i].Cells["Estado"].Value.ToString();
                    Txtcidade.Text = Dgvpf.Rows[i].Cells["Cidade"].Value.ToString();
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
                ConsultPf.Clear();
                ConsultPf.Select();
     
            }
            

            

        }

        private void Limpar(object sender, EventArgs e)
        {
            Txtid.Clear();
            Txtnome.Clear();
            Txtsexo.Clear();
            Txtcpf.Clear();
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
            if(Txtid.Text==string.Empty)
            {
                MessageBox.Show("Não há cliente selecionado");
                Btnexcluir.Enabled = false;
            }
            //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão e comparar o botão apertado
            else if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                retorno2 = contrendpf.excluirClientepfController(Txtid.Text);

                retorno = contr.excluirUsuarioController(Txtid.Text);
                preecherTabela();

                Txtid.Clear();
                Txtnome.Clear();
                Txtsexo.Clear();
                Txtcpf.Clear();
                Txtemail.Clear();
                Txttelefone.Clear();
                Txtcel.Clear();
                Btnexcluir.Enabled = false;

                //Sua rotina de exclusão
                //Confirmando exclusão para o usuário
                MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           



           
        }

        private void Btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            tela.Show();

        }
        
    }

   


}


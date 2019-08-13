using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Controller;

namespace view
{
    public partial class Setor : Form
    {
        ManipuladoresDeTela manipuladorTela = new ManipuladoresDeTela();
        TelaMenuPrincipal menu = new TelaMenuPrincipal();
        public Setor()
        {
            InitializeComponent();

        }

        string setorSelecionado;

        DataTable tabela = new DataTable();
        ControllerSetor contr = new ControllerSetor();

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtSetor.Text == string.Empty)
            {
                MessageBox.Show("Insira um valor");
                TxtSetor.Select();
                return;
            }

            int i = 0;
            while (i <= tabela.Rows.Count - 1)
            {
                if (tabela.Rows[i]["nomeSetor"].ToString() == TxtSetor.Text)
                {
                    MessageBox.Show("Setor já existe");
                    TxtSetor.Clear();
                    TxtSetor.Select();
                    return;
                }
                i++;
            }

            MessageBox.Show("Cadastrado com sucesso");
            contr.gravarSetorController(TxtSetor.Text);
            preecherTabela();
        }
        public void preecherTabela()
        {
            tabela = contr.preencherTabela();
            DgvSetor.DataSource = tabela;
        }

        private void Setor_Load(object sender, EventArgs e)
        {
            preecherTabela();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TxtSetor.Text == string.Empty)
            {
                MessageBox.Show("Campo Em Branco");
                TxtSetor.Select();
                return;
            }


            int i = 0;
            Boolean setorencontrado = false;
            while (i <= tabela.Rows.Count - 1)
            {
                if (tabela.Rows[i]["nomeSetor"].ToString() == TxtSetor.Text)
                {
                    setorencontrado = true;
                    DgvSetor.CurrentCell = DgvSetor.Rows[i].Cells["nomeSetor"];

                    setorSelecionado = DgvSetor.Rows[i].Cells["nomeSetor"].Value.ToString();
                    Btnexcluir.Enabled = true;

                    return;
                }
                else
                {
                    setorencontrado = false;
                }
                i++;
            }

            if (setorencontrado.Equals(false))
            {
                MessageBox.Show("Setor não cadastrado.");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {



                if (setorSelecionado == string.Empty)
                {
                    MessageBox.Show("Setor não cadastrado");
                    TxtSetor.Select();
                    return;
                }


                contr.excluirSetorController(setorSelecionado);
                preecherTabela();
                setorSelecionado = "";
                TxtSetor.Clear();
                Btnexcluir.Enabled = false;
                MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btnvoltar_Click(object sender, EventArgs e)
        {

            this.Close();
            menu.Show();

        }

    }


}



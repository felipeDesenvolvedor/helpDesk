using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace model
{
    public class Conexao
    {
        // DBCC CHECKIDENT('[tbSetor]', RESEED, 0) zera a contagem de PK da tabela 
        // string de conexao
        private string StrConexao = "Data Source=servidor-sql-felipe.database.windows.net;Initial Catalog=bdHelpDesk;User ID=helpDesk; Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public string USUARIO_INSERIR              = "USUARIO_INSERIR";
        public string USUARIO_CONSULTAR            = "USUARIO_CONSULTAR";
        public string USUARIO_EDITAR_NOME          = "USUARIO_EDITAR_NOME";
        public string USUARIO_EXCLUIR              = "USUARIO_EXCLUIR";

        public string USUARIO_CONSULTAR_NOME       = "USUARIO_CONSULTAR_NOME";
        public string USUARIO_CONSULTAR_NOME_ID    = "USUARIO_CONSULTAR_NOME_ID";
        public string USUARIO_CONSULTAR_NOME_SENHA = "USUARIO_CONSULTAR_NOME_SENHA";
        public string USUARIO_CONSULTAR_USUARIOS   = "USUARIO_CONSULTAR_USUARIOS";
        public string USUARIO_EDITAR_NOME_SENHA    = "USUARIO_EDITAR_NOME_SENHA";
        public string USUARIO_EDITAR_SENHA         = "USUARIO_EDITAR_SENHA";



        public string SETOR_INSERIR   = "SETOR_INSERIR";
        public string CONSULTA_SETOR  = "CONSULTA_SETOR";
        public string SETOR_EDITAR    = "SETOR_EDITAR";
        public string SETOR_EXCLUIR   = "SETOR_EXCLUIR";

      

        public string ADM_INSERIR   = "ADM_INSERIR";
        public string ADM_CONSULTAR = "ADM_CONSULTAR";
        public string ADM_EDITAR    = "ADM_EDITAR";
        public string ADM_EXCLUIR   = "ADM_EXCLUIR";



        public string TECNICO_INSERIR   = "TECNICO_INSERIR";
        public string TECNICO_CONSULTAR = "TECNICO_CONSULTAR";
        public string TECNICO_EDITAR    = "TECNICO_EDITAR";
        public string TECNICO_EXCLUIR   = "TECNICO_EXCLUIR";



        public string ATENDENTE_INSERIR   = "ATENDENTE_INSERIR";
        public string ATENDENTE_CONSULTAR = "ATENDENTE_CONSULTAR";
        public string ATENDENTE_EDITAR    = "ATENDENTE_EDITAR";
        public string ATENDENTE_EXCLUIR   = "ATENDENTE_EXCLUIR";



        public string ABRIR_OS = "ABRIR_OS";
        public string FECHAR_OS = "FECHAR_OS";
        public string EDITAR_OS = "EDITAR_OS";
        public string CONSULTAR_OS = "CONSULTAR_OS";

        public string FUNCIONARIOS_CONSULTAR = "FUNCIONARIOS_CONSULTAR";
        public string LOGIN_USUARIOS = "LOGIN_USUARIOS";

        public string CONSULTAR_PF = "CONSULTAR_PF";
        public string CONSULTAR2_PF = "CONSULTAR2_PF";
        public string CLIENTEPF_EXCLUIR = "CLIENTEPF_EXCLUIR";
        public string CLIENTEPF_EDITAR = "CLIENTEPF_EDITAR";
        public string CLIENTES_CONSULTAR = "CLIENTES_CONSULTAR";
        public string PF_INSERIR = "PF_INSERIR";

        public string ENDERECOPF_INSERIR = "ENDERECOPF_INSERIR";
        public string ENDERECOPF_EXCLUIR = "ENDERECOPF_EXCLUIR";
        public string ENDERECOPF_EDITAR = "ENDERECOPF_EDITAR";
        public string ENDERECOPF_CONSULTAR = "ENDERECOPF_CONSULTAR";

        public string CONSULTAR_PJ = "CONSULTAR_PJ";
        public string CONSULTAR2_PJ = "CONSULTAR2_PJ";
        public string CLIENTEPJ_EXCLUIR = "CLIENTEPJ_EXCLUIR";
        public string CLIENTEPJ_EDITAR = "CLIENTEPJ_EDITAR";
        public string PJ_INSERIR = "PJ_INSERIR";

        public string ENDERECOPJ_INSERIR = "ENDERECOPJ_INSERIR";
        public string ENDPJ_ALTERAR = "ENDPJ_ALTERAR";
        public string ENDERECOPJ_EXCLUIR = "ENDERECOPJ_EXCLUIR";

        public string PESSOAFISICA = "pessoa fisica";
        public string PESSOAJURIDICA = "pessoa juridica";



        public string getConexao()
        {
            return StrConexao;
        }

        //funcao generica de gravação 
        public void gravar(string nomeProcedure, ArrayList parametros) {

            try
            {
                SqlConnection con = new SqlConnection(getConexao());
                SqlCommand comando = new SqlCommand(nomeProcedure, con);
                comando.CommandType = CommandType.StoredProcedure;
                object retorno = 0;

                int linhas = parametros.Count;

                for (int i = 0; i <= linhas - 1; i++)
                {
                    comando.Parameters.AddWithValue(parametros[i].ToString(), parametros[++i].ToString());

                }

                //abrindo e fechando conexao e executando Procedure
                con.Open();
                retorno = comando.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public DataTable consultar(string nomeProcedure, string parametroNome, string parametroValor)
        {
            DataTable tabela = new DataTable();
           
             try
             {
                //string query = "select * from tbUsuario";
                 SqlConnection con = new SqlConnection(getConexao());
                 SqlCommand comando = new SqlCommand(nomeProcedure, con);
                 comando.CommandType = CommandType.StoredProcedure;
                 con.Open();
                SqlDataReader retorno = null;

                if (!string.IsNullOrEmpty(nomeProcedure) && !string.IsNullOrEmpty(parametroNome) && !string.IsNullOrEmpty(parametroValor)) {
                    comando.Parameters.AddWithValue(parametroNome, parametroValor);

                    retorno = comando.ExecuteReader();
                }
                else
                {
                    retorno = comando.ExecuteReader();
                }
                   
                    tabela.Load(retorno);
       
                    con.Close();
                
               
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Mensagem: " + ex.Message.ToString());
             }

            return tabela;
        }

        public int excluir(string nomeProcedure, ArrayList parametros)
        {
            SqlConnection con = new SqlConnection(getConexao());
            SqlCommand comando = new SqlCommand(nomeProcedure, con);
            comando.CommandType = CommandType.StoredProcedure;
            con.Open();
            int retorno = 0;

            if (!string.IsNullOrEmpty(nomeProcedure) && !parametros.Equals(""))
            {
                int linhas = parametros.Count;

                for (int i = 0; i <= linhas - 1; i++)
                {
                    comando.Parameters.AddWithValue(parametros[i].ToString(), parametros[++i].ToString());

                }
            }
        
            // abrindo e fechando conexao e executando Procedure 
            retorno = comando.ExecuteNonQuery();
            con.Close();

            return retorno;
        }

        public int editar(string nomeProcedure, ArrayList parametros)
        {
            int retorno = 0;
            try
            {
                SqlConnection con = new SqlConnection(getConexao());
                SqlCommand comando = new SqlCommand(nomeProcedure, con);
                comando.CommandType = CommandType.StoredProcedure;


                int linhas = parametros.Count;

                for (int i = 0; i <= linhas - 1; i++)
                {
                    comando.Parameters.AddWithValue(parametros[i].ToString(), parametros[++i].ToString());

                }

                //abrindo e fechando conexao e executando Procedure
                con.Open();
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return retorno;
        }
    }
}

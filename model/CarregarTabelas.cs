using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace model
{
    public class CarregarTabelas : Conexao
    {
        public DataTable usuarios { get; set; }

        public DataTable carregarUsuariosFuncionarios()
        {

            return consultar(USUARIO_CONSULTAR_USUARIOS, "", "");
        }


        public DataTable carregarUsuarios()
        {
            usuarios = consultar(USUARIO_CONSULTAR, "", "");
            return usuarios;
        }

        public DataTable carregarADM()
        {

            return consultar(FUNCIONARIOS_CONSULTAR, "", "");
        }   

        public DataTable logar()
        {
            usuarios = consultar(LOGIN_USUARIOS, "", "");
            return usuarios;
        }

        public DataTable carregarClientes()
        {
            return consultar(CLIENTES_CONSULTAR, "", "");
        }

        public DataTable carregarClientePfend() // Carrega o inner join tabela pf e endereço pf
        {

            return consultar(CONSULTAR2_PF, "", "");
        }



        public DataTable carregarClientepf() //Carrega tabela pf
        {
            return consultar(CONSULTAR_PF, "", "");
        }

        public DataTable carregarClientepj() //Carrega tabela pf
        {
            return consultar(CONSULTAR_PJ, "", "");
        }

        public DataTable carregarClientePjend() // Carrega o inner join tabela pf e endereço pf
        {

            return consultar(CONSULTAR2_PJ, "", "");
        }
    }
}

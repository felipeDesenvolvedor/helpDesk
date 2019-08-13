using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
//using System.Windows.Forms;

namespace Controller
{
    public class ControllerUsuario
    {
        ModelUsuario mdlUsuario = new ModelUsuario();
        DataTable tabela = new DataTable();
        CarregarTabelas usuarios = new CarregarTabelas();

        public void gravarUsuarioController(string usuario)
        {
            mdlUsuario.Usuario = usuario;
            mdlUsuario.Senha = "mudar1234";

            mdlUsuario.gravarUsuarioModel();
        }

        public int excluirUsuarioController(int codUsuario, string tabelaAssociada)
        {
            mdlUsuario.codUsuario = codUsuario;
            mdlUsuario.tabelaAssociada = tabelaAssociada;

            return mdlUsuario.excluirUsuarioModel();
        }

        public int editarUsuarioController(int codUsuario, string usuario, string senha)
        {
            mdlUsuario.codUsuario = codUsuario;
            mdlUsuario.Usuario = usuario;
            mdlUsuario.Senha = senha;

            return mdlUsuario.editarUsuarioModel();
        }

        public DataTable consultarUsuario()
        {
            tabela = usuarios.carregarUsuarios();
            return tabela;
        }

        public Boolean validarUsuarios(DataTable tabela, string usuario)
        {

            bool retorno = false;
            int i = 0;
            while (i <= tabela.Rows.Count - 1)
            {
                if (tabela.Rows[i]["usuario"].ToString() == usuario)
                {
                    retorno = true;
                }
                i++;
            }
            return retorno;
        }
    }
}

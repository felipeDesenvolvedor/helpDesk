using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace model
{
    public class ModelUsuario:Conexao
    {
        //propriedades da class
        public int codUsuario { get; set; }
        public string Usuario { get; set; }
        public string Senha   { get; set; }
        public string tabelaAssociada { get; set; }

        // variaveis auxiliares
        ArrayList  parametrosProcedure = new ArrayList();

        public void gravarUsuarioModel()
        {
            parametrosProcedure.Clear();

            parametrosProcedure.Add("@usuario");
            parametrosProcedure.Add(Usuario);

            parametrosProcedure.Add("@senha");
            parametrosProcedure.Add(Senha);

            gravar(USUARIO_INSERIR, parametrosProcedure);
        }

        public int excluirUsuarioModel()
        {
            parametrosProcedure.Clear();

            parametrosProcedure.Add("@codUsuario");
            parametrosProcedure.Add(codUsuario);

            parametrosProcedure.Add("@tabelaAssociada");
            parametrosProcedure.Add(tabelaAssociada);

            return excluir(USUARIO_EXCLUIR, parametrosProcedure);
        }

        public int editarUsuarioModel() {
            parametrosProcedure.Clear();

            int retorno; 
            parametrosProcedure.Add("@codUsuario");
            parametrosProcedure.Add(codUsuario);

            parametrosProcedure.Add("@usuario");
            parametrosProcedure.Add(Usuario);

            parametrosProcedure.Add("@senha");
            parametrosProcedure.Add(Senha);

            retorno = editar(USUARIO_EDITAR_NOME_SENHA, parametrosProcedure);
           
            return retorno;
        }

      }
}

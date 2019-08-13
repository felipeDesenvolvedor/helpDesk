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
   public class ModelEnderecoPJ:Conexao
    {
        //propriedades da class

        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Numero { get; set; }
        public int IdpJ { get; set; }
        public string codend { get; set; }



        // variaveis auxiliares
        ArrayList parametrosProcedure = new ArrayList();

        public void gravarUsuarioModel()
        {
            parametrosProcedure.Clear();

            parametrosProcedure.Add("@logradouro");
            parametrosProcedure.Add(Logradouro);

            parametrosProcedure.Add("@cep");
            parametrosProcedure.Add(Cep);

            parametrosProcedure.Add("@bairro");
            parametrosProcedure.Add(Bairro);

            parametrosProcedure.Add("@estado");
            parametrosProcedure.Add(Estado);

            parametrosProcedure.Add("@cidade");
            parametrosProcedure.Add(Cidade);

            parametrosProcedure.Add("@numero");
            parametrosProcedure.Add(Numero);

            parametrosProcedure.Add("@codcliente");
            parametrosProcedure.Add(IdpJ);

            gravar(ENDERECOPJ_INSERIR, parametrosProcedure);
        }

        public int excluirUsuarioModel()
        {
            parametrosProcedure.Clear();

            parametrosProcedure.Add("@codcliente");
            parametrosProcedure.Add(codend);


            return excluir(ENDERECOPJ_EXCLUIR, parametrosProcedure);
        }

        public int editarUsuarioModel()
        {
            parametrosProcedure.Clear();

            int retorno;
            parametrosProcedure.Add("@logradouro");
            parametrosProcedure.Add(Logradouro);

            parametrosProcedure.Add("@cep");
            parametrosProcedure.Add(Cep);

            parametrosProcedure.Add("@bairro");
            parametrosProcedure.Add(Bairro);

            parametrosProcedure.Add("@estado");
            parametrosProcedure.Add(Estado);

            parametrosProcedure.Add("@cidade");
            parametrosProcedure.Add(Cidade);

            parametrosProcedure.Add("@numero");
            parametrosProcedure.Add(Numero);

            parametrosProcedure.Add("@codcliente");
            parametrosProcedure.Add(IdpJ);


            retorno = editar(ENDPJ_ALTERAR, parametrosProcedure);
            return retorno;
        }


    }
}



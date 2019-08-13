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
  public  class ModelPJ:Conexao
  {

        //propriedades da class
        public string Razaosicial { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }
        public string tipoCliente { get; set; }


        // variaveis auxiliares
        ArrayList parametrosProcedure = new ArrayList();

        public void gravarClientepfModel()
        {
            parametrosProcedure.Clear();

            parametrosProcedure.Add("@razaosocial");
            parametrosProcedure.Add(Razaosicial);

            parametrosProcedure.Add("@cnpj");
            parametrosProcedure.Add(Cnpj);

            parametrosProcedure.Add("@email");
            parametrosProcedure.Add(Email);

            parametrosProcedure.Add("@telefone");
            parametrosProcedure.Add(Telefone);

            parametrosProcedure.Add("@celular");
            parametrosProcedure.Add(Celular);

            parametrosProcedure.Add("@tipocliente");
            parametrosProcedure.Add(tipoCliente);

            gravar(PJ_INSERIR, parametrosProcedure);
        }

        public int excluirClientepfModel()
        {
            parametrosProcedure.Clear();

            parametrosProcedure.Add("@codcliente");
            parametrosProcedure.Add(Id);


            return excluir(CLIENTEPJ_EXCLUIR, parametrosProcedure);
        }

        public int editarClientepfModel()
        {

            int retorno;
            parametrosProcedure.Clear();

            parametrosProcedure.Add("@razaosocial");
            parametrosProcedure.Add(Razaosicial);

            parametrosProcedure.Add("@cnpj");
            parametrosProcedure.Add(Cnpj);

            parametrosProcedure.Add("@email");
            parametrosProcedure.Add(Email);

            parametrosProcedure.Add("@telefone");
            parametrosProcedure.Add(Telefone);

            parametrosProcedure.Add("@celular");
            parametrosProcedure.Add(Celular);

            parametrosProcedure.Add("@codcliente");
            parametrosProcedure.Add(Id);



            retorno = editar(CLIENTEPJ_EDITAR, parametrosProcedure);
            return retorno;
        }


    }
}

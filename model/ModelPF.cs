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
    public class ModelPF:Conexao
    {
        //propriedades da class
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
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

            parametrosProcedure.Add("@nomeClientePF");
            parametrosProcedure.Add(Nome);
            
            parametrosProcedure.Add("@sexoPF");
            parametrosProcedure.Add(Sexo);

            parametrosProcedure.Add("@cpfPF");
            parametrosProcedure.Add(Cpf);

            parametrosProcedure.Add("@emailPF");
            parametrosProcedure.Add(Email);

            parametrosProcedure.Add("@telefonePF");
            parametrosProcedure.Add(Telefone);

            parametrosProcedure.Add("@celularPF");
            parametrosProcedure.Add(Celular);

            parametrosProcedure.Add("@tipocliente");
            parametrosProcedure.Add(tipoCliente);

            gravar(PF_INSERIR, parametrosProcedure);
        }

        public int excluirClientepfModel()
        {
            parametrosProcedure.Clear();

            parametrosProcedure.Add("@codcliente");
            parametrosProcedure.Add(Id);
            

            return excluir(CLIENTEPF_EXCLUIR, parametrosProcedure);
        }

        public int editarClientepfModel()
        {
     
            int retorno;
            parametrosProcedure.Clear();

            parametrosProcedure.Add("@codcliente");
            parametrosProcedure.Add(Id);

            parametrosProcedure.Add("@nomepf");
            parametrosProcedure.Add(Nome);

            parametrosProcedure.Add("@sexopf");
            parametrosProcedure.Add(Sexo);

            parametrosProcedure.Add("@cpfpf");
            parametrosProcedure.Add(Cpf);

            parametrosProcedure.Add("@emailpf");
            parametrosProcedure.Add(Email);

            parametrosProcedure.Add("@telefonepf");
            parametrosProcedure.Add(Telefone);

            parametrosProcedure.Add("@celularpf");
            parametrosProcedure.Add(Celular);


            retorno = editar(CLIENTEPF_EDITAR, parametrosProcedure);
            return retorno;
        }

    }
}

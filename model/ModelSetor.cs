using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace model
{
    public class ModelSetor : Conexao
    {
        public string Setor { get; set; }

        // variaveis auxiliares
        public ArrayList parametrosProcedure = new ArrayList();

        public void gravarSetorModel()
        {
            parametrosProcedure.Clear();
            parametrosProcedure.Add("@setor");
            parametrosProcedure.Add(Setor);



            gravar(SETOR_INSERIR, parametrosProcedure);
        }

        public DataTable preencherTabela()
        {
            DataTable tabela = consultar(CONSULTA_SETOR, "", "");
            return tabela;
        }

        public void excluirSetorModel()
        {
            parametrosProcedure.Clear();
            parametrosProcedure.Add("@setor");
            parametrosProcedure.Add(Setor);


            excluir(SETOR_EXCLUIR,parametrosProcedure);
        }

    }
}

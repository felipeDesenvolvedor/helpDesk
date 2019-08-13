using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class ModelAtendente : Conexao
    {
        public int codAtendente { get; set; }
        public string nomeAtendente { get; set; }
        public int codSetor { get; set; }
        public int codUsuario { get; set; }

        ArrayList parametrosProcedure = new ArrayList();

        public void gravarAtendenteModel()
        {
            parametrosProcedure.Clear();

            parametrosProcedure.Add("@nomeAtendente");
            parametrosProcedure.Add(nomeAtendente);

            parametrosProcedure.Add("@codSetor");
            parametrosProcedure.Add(codSetor);

            parametrosProcedure.Add("@codUsuario");
            parametrosProcedure.Add(codUsuario);

            gravar(ATENDENTE_INSERIR, parametrosProcedure);
        }

        public int editarAtendenteModel()
        {
            parametrosProcedure.Clear();

            parametrosProcedure.Add("@codAtendente");
            parametrosProcedure.Add(codAtendente);

            parametrosProcedure.Add("@nomeAtendente");
            parametrosProcedure.Add(nomeAtendente);

            return editar(ATENDENTE_EDITAR, parametrosProcedure);
        }
    }
}

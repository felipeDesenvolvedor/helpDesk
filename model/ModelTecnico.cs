using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class ModelTecnico:Conexao
    {
        public int codTecnico { get; set; }
        public string nomeTecnico { get; set; }
        public int codSetor { get; set; }
        public int codUsuario { get; set; }

        ArrayList parametrosProcedure = new ArrayList();

        public void gravarTecnicoModel()
        {
            parametrosProcedure.Clear();
            parametrosProcedure.Add("@nomeTecnico");
            parametrosProcedure.Add(nomeTecnico);

            parametrosProcedure.Add("@codSetor");
            parametrosProcedure.Add(codSetor);

            parametrosProcedure.Add("@codUsuario");
            parametrosProcedure.Add(codUsuario);

            gravar(TECNICO_INSERIR, parametrosProcedure);
        }

        public int editarTecnicoModel()
        {
            parametrosProcedure.Clear();

            parametrosProcedure.Add("@codTecnico");
            parametrosProcedure.Add(codTecnico);

            parametrosProcedure.Add("@nomeTecnico");
            parametrosProcedure.Add(nomeTecnico);

            return editar(TECNICO_EDITAR, parametrosProcedure);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace model
{
    public class ModelADM:Conexao
    {
        public string nomeADM { get; set; }
        public int codAdm { get; set; }
        public int codSetor { get; set; }
        public int codUsuario { get; set; }
       
        ArrayList parametrosProcedure = new ArrayList();

        public void gravarAdmModel()
        {
            parametrosProcedure.Clear();

            parametrosProcedure.Add("@nomeADM");
            parametrosProcedure.Add(nomeADM);

            parametrosProcedure.Add("@codSetor");
            parametrosProcedure.Add(codSetor);

            parametrosProcedure.Add("@codUsuario");
            parametrosProcedure.Add(codUsuario);

            gravar(ADM_INSERIR, parametrosProcedure);
        }

            public int editarAdmModel()
            {
                parametrosProcedure.Clear();

                parametrosProcedure.Add("@codADM");
                parametrosProcedure.Add(codAdm);

                parametrosProcedure.Add("@nomeADM");
                parametrosProcedure.Add(nomeADM);

               return editar(ADM_EDITAR, parametrosProcedure);
            } 
    }
}

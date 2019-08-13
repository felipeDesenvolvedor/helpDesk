using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace Controller
{
    public class ControllerADM
    {
        ModelADM mdlADM = new ModelADM();

        public void gravarAdmController(string nomeADM, int codSetor, int codUsuario)
        {
            mdlADM.nomeADM = nomeADM;
            mdlADM.codSetor = codSetor;
            mdlADM.codUsuario = codUsuario;

            mdlADM.gravarAdmModel();
        }

        public int editarAdmController(int codAdm, string nomeFuncionario)
        {
            mdlADM.codAdm = codAdm;
            mdlADM.nomeADM = nomeFuncionario;

            return mdlADM.editarAdmModel();
        }
    }
}

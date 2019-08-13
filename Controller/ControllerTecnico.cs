using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace Controller
{
    public class ControllerTecnico
    {
        ModelTecnico mdlTecnico = new ModelTecnico();

        public void gravarTecnicoController(string nomeTecnico, int codSetor, int codUsuario)
        {
            mdlTecnico.nomeTecnico = nomeTecnico;
            mdlTecnico.codSetor = codSetor;
            mdlTecnico.codUsuario = codUsuario;

            mdlTecnico.gravarTecnicoModel();
        }

        public int editarTecnicoController(int codTecnico, string nomeTecnico)
        {
            mdlTecnico.codTecnico = codTecnico;
            mdlTecnico.nomeTecnico = nomeTecnico;

            return mdlTecnico.editarTecnicoModel();
        }
    }
}

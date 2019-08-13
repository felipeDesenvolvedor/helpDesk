using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace Controller
{
    public class ControllerAtendente
    {
        ModelAtendente mdlAtendente = new ModelAtendente();

        public void gravarAtendenteController(string nomeAtendente, int codSetor, int codUsuario)
        {
            mdlAtendente.nomeAtendente = nomeAtendente;
            mdlAtendente.codSetor = codSetor;
            mdlAtendente.codUsuario = codUsuario;

            mdlAtendente.gravarAtendenteModel();
        }

        public int editarAtendenteController(int codAtendente, string nomeFuncionario)
        {
            mdlAtendente.codAtendente = codAtendente;
            mdlAtendente.nomeAtendente = nomeFuncionario;

            return mdlAtendente.editarAtendenteModel();
        }
    }
}

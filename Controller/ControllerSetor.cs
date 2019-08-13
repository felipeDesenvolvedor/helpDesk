using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using model;

namespace Controller
{
    public class ControllerSetor
    {
        ModelSetor Mdlsetor = new ModelSetor();


        public void gravarSetorController(string setor)
        {
            Mdlsetor.Setor = setor;


            Mdlsetor.gravarSetorModel();
        }

        public void excluirSetorController(string setor)
        {
            Mdlsetor.Setor = setor;
            Mdlsetor.excluirSetorModel();
        }

        public DataTable preencherTabela()
        {
            return Mdlsetor.preencherTabela();
        }
    }
}

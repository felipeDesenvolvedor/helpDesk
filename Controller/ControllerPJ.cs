using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace Controller
{
    public class ControllerPJ
    {
        ModelPJ model = new ModelPJ();

        public void gravarClientepfController(string Razaosocial, string Cnpj, string Email, string Telefone, string Celular, string tipoCliente)
        {
            model.Razaosicial = Razaosocial;
            model.Cnpj = Cnpj;
            model.Email = Email;
            model.Telefone = Telefone;
            model.Celular = Celular;
            model.tipoCliente = tipoCliente;

            model.gravarClientepfModel();
        }

        public int excluirClientepfController(string cod)
        {
            model.Id = cod;


            return model.excluirClientepfModel();
        }

        public int editarClientepfController(string Razaosocial, string Cnpj, string Email, string Telefone, string Celular, string Codcliente)
        {
            model.Razaosicial = Razaosocial;
            model.Cnpj = Cnpj;
            model.Email = Email;
            model.Telefone = Telefone;
            model.Celular = Celular;
            model.Id = Codcliente;




            return model.editarClientepfModel();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace Controller
{
    public class ControllerPF
    {
        ModelPF Pf = new ModelPF();

        public void gravarUsuarioController(string Nome, string Sexo, string Cpf, string Email, string Telefone, string Celular, string tipocliente)
        {
            Pf.Nome = Nome;
            Pf.Sexo = Sexo;
            Pf.Cpf = Cpf;
            Pf.Email = Email;
            Pf.Telefone = Telefone;
            Pf.Celular = Celular;
            Pf.tipoCliente = tipocliente;


            Pf.gravarClientepfModel();
        }

        public int excluirUsuarioController(string Id)
        {
            Pf.Id = Id;


            return Pf.excluirClientepfModel();
        }

        public int editarUsuarioController(string Id, string Nome, string Sexo, string Cpf, string Email, string Telefone, string Celular)
        {
            Pf.Id = Id;
            Pf.Nome = Nome;
            Pf.Cpf = Cpf;
            Pf.Sexo = Sexo;
            Pf.Telefone = Telefone;
            Pf.Celular = Celular;
            Pf.Email = Email;


            return Pf.editarClientepfModel();
        }
    }
}

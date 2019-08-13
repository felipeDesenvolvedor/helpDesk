using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace Controller
{
    public class ControllerEnderecoPJ
    {
        ModelEnderecoPJ endPj = new ModelEnderecoPJ();

        public void gravarUsuarioController(string Logradouro, string Cep, string Bairro, string Estado, string Cidade, string Numero, int Codcliente)
        {
            endPj.Logradouro = Logradouro;
            endPj.Cep = Cep;
            endPj.Bairro = Bairro;
            endPj.Estado = Estado;
            endPj.Cidade = Cidade;
            endPj.Numero = Numero;
            endPj.IdpJ = Codcliente;


            endPj.gravarUsuarioModel();
        }

        public int excluirUsuarioController(string cod)
        {
            endPj.codend = cod;


            return endPj.excluirUsuarioModel();
        }

        public int editarUsuarioController(string Logradouro, string Cep, string Bairro, string Estado, string Cidade, string Numero, int Codcliente)
        {
            endPj.Logradouro = Logradouro;
            endPj.Cep = Cep;
            endPj.Bairro = Bairro;
            endPj.Estado = Estado;
            endPj.Cidade = Cidade;
            endPj.Numero = Numero;
            endPj.IdpJ = Codcliente;




            return endPj.editarUsuarioModel();
        }
    }
}

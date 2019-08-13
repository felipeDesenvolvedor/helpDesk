using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace Controller
{
    public class ControllerEnderecoPF
    {
        ModelEnderecoPF endPj = new ModelEnderecoPF();

        public void gravarClientepfController(string Logradouro, string Cep, string Bairro, string Estado, string Cidade, string Numero, int Codcliente)
        {
            endPj.Logradouro = Logradouro;
            endPj.Cep = Cep;
            endPj.Bairro = Bairro;
            endPj.Estado = Estado;
            endPj.Cidade = Cidade;
            endPj.Numero = Numero;
            endPj.Idpf = Codcliente;


            endPj.gravarUsuarioModel();
        }

        public int excluirClientepfController(string cod)
        {
            endPj.codend = cod;


            return endPj.excluirUsuarioModel();
        }

        public int editarClientepfController(string Logradouro, string Cep, string Bairro, string Estado, string Cidade, string Numero, int Codcliente)
        {
            endPj.Logradouro = Logradouro;
            endPj.Cep = Cep;
            endPj.Bairro = Bairro;
            endPj.Estado = Estado;
            endPj.Cidade = Cidade;
            endPj.Numero = Numero;
            endPj.Idpf = Codcliente;




            return endPj.editarUsuarioModel();
        }
    }
}

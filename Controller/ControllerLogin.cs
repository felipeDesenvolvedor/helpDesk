using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace Controller
{
    public class ControllerLogin
    {
        CarregarTabelas usuarios = new CarregarTabelas();
        DataTable tabelaUsuarios = new DataTable();
        ArrayList resposta = new ArrayList();
        string varUsuario, varSenha;
        int codSetor;
        string nomeSetor;
        public string mensagemUsuario = "Usuario não cadastrado.";
        public string mensagemSenha = "Senha incorreta";



        public ArrayList controllerLogar(string usuario, string senha)
        {
            resposta.Clear();
            tabelaUsuarios = usuarios.logar();

            int i = 0;
            while (i <= tabelaUsuarios.Rows.Count - 1)
            {
                varUsuario = tabelaUsuarios.Rows[i]["Usuario"].ToString();
                varSenha = tabelaUsuarios.Rows[i]["Senha"].ToString();
                codSetor = (Int32)tabelaUsuarios.Rows[i]["Setor"];
                nomeSetor = tabelaUsuarios.Rows[i]["nomeSetor"].ToString();

                if (varUsuario.Equals(usuario) && varSenha.Equals(senha))
                {
                    resposta.Clear();
                    resposta.Add(true);
                    resposta.Add(codSetor);
                    resposta.Add(nomeSetor);
                    break;
                }
                else if (varUsuario.Equals(usuario) && !varSenha.Equals(senha))
                {
                    resposta.Clear();
                    resposta.Add(mensagemSenha);
                    break;
                }
                else
                {
                    resposta.Clear();
                    resposta.Add(mensagemUsuario);
                }
                i++;
            }
            return resposta;
        }
    }
}

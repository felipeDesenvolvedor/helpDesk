using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using model;

namespace Controller
{
    public class ControllerOS
    {
        ModelOS OS = new ModelOS();

        public int abrirOSController(string dataAbertura, string prioridadeOS, string statusOS, string tecnico, string cliente, string descricao, string categoria, int codTecnico, int codCliente, string tipoCliente)
        {
            OS.DataAbertura = dataAbertura;
            OS.PrioridadeOS = prioridadeOS;
            OS.StatusOS = statusOS;
            OS.NomeTecnico = tecnico;
            OS.NomeCliente = cliente;
            OS.DescricaoOS = descricao;
            OS.CategoriaEquipamento = categoria;
            OS.CodTecnico = codTecnico;
            OS.CodCliente = codCliente;
            OS.TipoCliente = tipoCliente;

            return OS.abrirOsModel();
        }

        public DataTable consultarOsController()
        {
            return OS.consultarOsModel();
        }

        public int editarOS(int codOS, int codTecnico, string prioridade)
        {

            OS.CodOS = codOS;
            OS.CodTecnico = codTecnico;
            OS.PrioridadeOS = prioridade;

            return OS.editarOS();
        }
    }
}

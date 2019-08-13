using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class ModelOS:Conexao
    {
        public int CodOS { get; set; }
        public string DataAbertura { get; set; }
        public string DataFechamento { get; set; }
        public string PrioridadeOS { get; set; }
        public string StatusOS { get; set; }
        public string NomeTecnico { get; set; }
        public string NomeCliente { get; set; }
        public string DescricaoOS { get; set; }
        public string CategoriaEquipamento { get; set; }
        public int CodTecnico { get; set; }
        public int CodCliente { get; set; }
        public string TipoCliente { get; set; }

        ArrayList parametrosProcedure = new ArrayList();

        public int abrirOsModel()
        {
            parametrosProcedure.Clear();

            parametrosProcedure.Add("@dataAbertura");
            parametrosProcedure.Add(DataAbertura);

            parametrosProcedure.Add("@prioridadeOS");
            parametrosProcedure.Add(PrioridadeOS);

            parametrosProcedure.Add("@statusOS");
            parametrosProcedure.Add(StatusOS);

            parametrosProcedure.Add("@nomeTecnico");
            parametrosProcedure.Add(NomeTecnico);

            parametrosProcedure.Add("@nomeCliente");
            parametrosProcedure.Add(NomeCliente);

            parametrosProcedure.Add("@descricaoOS");
            parametrosProcedure.Add(DescricaoOS);

            parametrosProcedure.Add("@categoriaEquipamento");
            parametrosProcedure.Add(CategoriaEquipamento);

            parametrosProcedure.Add("@codTecnico");
            parametrosProcedure.Add(CodTecnico);

            parametrosProcedure.Add("@codCliente");
            parametrosProcedure.Add(CodCliente);

            parametrosProcedure.Add("@tipoCliente");
            parametrosProcedure.Add(TipoCliente);

            gravar(ABRIR_OS, parametrosProcedure);

            return 1;
        }

        public DataTable consultarOsModel()
        {
            return consultar(CONSULTAR_OS, "", "");
        }

        public int editarOS()
        {
            parametrosProcedure.Clear();

            parametrosProcedure.Add("@codOS");
            parametrosProcedure.Add(CodOS);

            parametrosProcedure.Add("@codTecnico");
            parametrosProcedure.Add(CodTecnico);

            parametrosProcedure.Add("@prioridade"); 
            parametrosProcedure.Add(PrioridadeOS);

            return editar(EDITAR_OS, parametrosProcedure);
        }
    }
}

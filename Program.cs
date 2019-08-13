using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;
using controller;
using Controller;

namespace view
{
    public static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>

        public static int Setor { get; set; }

        private TelaMenuPrincipal menu = new TelaMenuPrincipal();
        CarregarTabelas carregarTabelas = new CarregarTabelas();
        DataTable funcionarios = new DataTable();
        DataTable clientes = new DataTable();

        ControllerOS OS = new ControllerOS();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new telaLogin());
        }

    }
}

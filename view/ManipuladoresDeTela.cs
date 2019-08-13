using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public class ManipuladoresDeTela : IManipuladoresDeTela
    {
        public int MostrarForm() {
            return 100;
        }

        public int EsconderForm()
        {
            return 0;
        }
    }
}

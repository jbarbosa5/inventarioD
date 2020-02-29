using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventarios
{
    public partial class Inicio : Form
    {
        public ImportarCVS importarCVS;

        public Inicio()
        {
            InitializeComponent();
        }

        private void leerArchivoCVSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importarCVS = new ImportarCVS();
            importarCVS.Show();
        }
    }
}

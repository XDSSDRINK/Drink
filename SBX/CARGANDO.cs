using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBX
{
    public partial class CARGANDO : Form
    {
        public CARGANDO()
        {
            InitializeComponent();
            progressBar1.Increment(0);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }
        public void Progreso(int Incremento)
        {
            this.progressBar1.Increment(Incremento);
        }
    }
}

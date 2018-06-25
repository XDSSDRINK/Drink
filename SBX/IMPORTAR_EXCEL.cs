using Microsoft.Office.Interop.Excel;
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
    public partial class IMPORTAR_EXCEL : Form
    {
        Microsoft.Office.Interop.Excel.Application _excelApp;
        Workbook woorkBook;
        public IMPORTAR_EXCEL()
        {
            InitializeComponent();
        }

        private void btnCargarInventario_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("ok");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("cancel");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

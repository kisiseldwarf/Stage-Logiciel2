using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class chiffreApresVirgule : Form
    {
        Main parent;
        public chiffreApresVirgule(Main parent)
        {
            InitializeComponent();
            this.parent = parent;
            parent.Enabled = false;
            inputNb.Maximum = 2;
            inputNb.Minimum = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            DialogResult res;
            dialog.Title = "Exporter en CSV";
            dialog.Filter = "CSV|*.csv";
            res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                parent.exportCSV(dialog.FileName, (int)inputNb.Value);
                Close();
            }
        }

        private void chiffreApresVirgule_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
        }
    }
}

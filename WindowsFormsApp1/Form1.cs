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

    public partial class F_Menu : System.Windows.Forms.Form
    {
        public F_Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenSotr(object sender, EventArgs e)
        {
            FormSotr f1 = new FormSotr();

            f1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void OpenPriceList(object sender, EventArgs e)
        {
            FormUsl f1 = new FormUsl();
            f1.ShowDialog();
        }

        private void ремонтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRemontAvto fr = new FormRemontAvto();
            fr.ShowDialog();
        }

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRedAvto f = new FormRedAvto();
            f.ShowDialog();
        }
    }
}

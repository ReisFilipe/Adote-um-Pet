using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadUser fm = new FrmCadUser();
            fm.ShowDialog();
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadDog fm = new FrmCadDog();
            fm.ShowDialog();
        }

        private void adotanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadAdotante fm = new FrmCadAdotante();
            fm.ShowDialog();
        }

        private void adoçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdocao fm = new FrmAdocao();
            fm.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscaAnimal fm = new FrmBuscaAnimal();
            fm.ShowDialog();
        }
    }
}

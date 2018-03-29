using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class FrmBuscaAnimal : Form
    {
        public FrmBuscaAnimal()
        {
            InitializeComponent();
        }

        private void FrmBuscaAnimal_Load(object sender, EventArgs e)
        {
            string conString = "server=localhost; user=root; pwd=skill; database=AdoteUmPet;";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();

            string query = "select ani_nome, ani_raca, ani_cor, ani_porte, ani_idade from animal where ani_data_adocao is null";

            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);

            DataTable data = new DataTable();
            adpt.Fill(data);

            dgvAnimal.DataSource = data;

        }

        private void dgvAnimal_Click(object sender, EventArgs e)
        {
            this.txbNome.Text = Convert.ToString(this.dgvAnimal.CurrentRow.Cells["ani_nome"].Value);
            this.txbRaca.Text = Convert.ToString(this.dgvAnimal.CurrentRow.Cells["ani_raca"].Value);
            this.txbPorte.Text = Convert.ToString(this.dgvAnimal.CurrentRow.Cells["ani_porte"].Value);
            this.txbCor.Text = Convert.ToString(this.dgvAnimal.CurrentRow.Cells["ani_cor"].Value);
            this.txbIdade.Text = Convert.ToString(this.dgvAnimal.CurrentRow.Cells["ani_idade"].Value);
    }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleciona_Click(object sender, EventArgs e)
        {
            string NomeAnimal = txbNome.Text;
            
        }
    }
}

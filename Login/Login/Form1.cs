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
    public partial class Form1 : Form
    {
        
        //conexao con = new conexao();
        int i;
        public Form1()
        {
            InitializeComponent();
           // con.Create();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = "server=localhost; user=root; pwd=skill; database=AdoteUmPet;";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            i = 0;
            
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select nome, senha from usuario where nome = '"+txbUsuario.Text+"' and senha = '"+txbSenha.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                label3.Text = "Usuario ou senha invalido";
            }
            else
            {
                this.Hide();
                Principal fm = new Principal();
                fm.Show();
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);

            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            string target = "https://plus.google.com/u/0/+filipereis97";
            System.Diagnostics.Process.Start(target);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

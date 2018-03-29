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
    public partial class FrmCadUser : Form
    {
        public FrmCadUser()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string Usuario  = txbUsuario.Text;
            string Senha    = txbSenha.Text;
            string cSenha   = txbConfirmaSenha.Text;
            if (Usuario == "" || Senha == "" || cSenha =="" )
            {
                MessageBox.Show("Você não pode deixar campo em branco!", "ERRO");
                return;
            }
            if (Senha != cSenha)
            {
                MessageBox.Show("As senhas são diferentes!", "ERRO");
                return;
            }

            string conString = "server=localhost; user=root; pwd=skill; database=AdoteUmPet;";
            MySqlConnection con = new MySqlConnection(conString);
            int i;

            i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select nome, senha from usuario where nome = '" + Usuario + "'" ;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            con.Close();
            if (i == 1)
            {
                MessageBox.Show("Nome de Usuario já existe!", "ERRO");
                return;
            }


            else
            {
                try
                {
                    con.Open();
                    MySqlCommand comando = new MySqlCommand("INSERT INTO usuario (nome, senha, data_cadastro) VALUES ('" + Usuario + "' , '" + Senha + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')", con);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Usuario " + Usuario + " Registrado ", "Usuario Registrado");
                    txbUsuario.Text = string.Empty;
                    txbSenha.Text = string.Empty;
                    txbConfirmaSenha.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao inserir os dados \n" + ex.Message + "\n Favor contactar o Suporte", "Erro de Conexão");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);

            }
        }
    }
}

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
    public partial class FrmCadAdotante : Form
    {
        public FrmCadAdotante()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string Nome = txbNome.Text;
            string Sexo = cbx_sexo.Text;
            string Cpf = mtbCpf.Text;
            string Documento = txbDocumento.Text;
            string Endereco = txbEndereco.Text;
            string Bairro = txbBairro.Text;
            string Cidade = txbCidade.Text;
            string Estado = txbEstado.Text;
            string Profissao = txbProfissao.Text;
            string Email = txbEmail.Text;
            string Celular = mtbCelular.Text;
            string Fixo = mtbFixo.Text;
            string Nascimento = mtbNascimento.Text;

            bool EmailValido = Email.Contains("@") && Email.Contains(".com");

            
            if (Nome == string.Empty)
            {
                lblNome.Text = "Campo Obrigatorio!";
                return;
            }
            else
            {
                lblNome.Text = "";
            }
            if (mtbCpf.Text == "   .   .   -")
            {
                lblCpf.Text =  "O campo CPF deve ser preenchido!";
                return;
            }
            else if (Endereco == string.Empty)
            {
                lblEndereco.Text = "O campo Endereço deve ser preenchido!";
                return;
            }
            else if (EmailValido == false)
            {
                lblEmail.Text = "O E-mail " + Email + " é invalido!";
                return;
            }
            else if (Celular == "" || Fixo == "")
            {
                lblContato.Text = "Um dos campos de telefone deve ser preenchido!";
                lblFixo.Text = "Um dos campos de telefone deve ser preenchido!";
                return;
            }

            string conString = "server=localhost; user=root; pwd=skill; database=AdoteUmPet;";
            MySqlConnection con = new MySqlConnection(conString);
            int i;

            i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select adt_cpf from adotante where adt_cpf = '" + Cpf + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            con.Close();
            if (i == 1)
            {
                MessageBox.Show("CPF já cadastrado!", "ERRO");
                return;
            }

            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO adotante (adt_nome, adt_sexo, adt_cpf, adt_identidade, adt_endereco, adt_bairro, "
                                 + " adt_cidade, adt_estado, adt_profissao, adt_email, adt_celular, adt_fone, adt_nascimento) "
                                 + " VALUES ( '"+Nome+"', '"+Sexo+"', '"+Cpf+"', '"+Documento+"', '"+Endereco+"', '"+Bairro+"', "
                                 + " '"+Cidade+"', '"+Estado+"', '"+Profissao+"', '"+Email+"', '"+Celular+"', '"+Fixo+"', '"+ Convert.ToDateTime(Nascimento).ToString("yyyy/MM/dd") + "' )";
                    MySqlCommand comando = new MySqlCommand(query, con);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Usuario " + Nome + " Registrado ", "Usuario Registrado");

                    txbNome.Text = string.Empty;
                    cbx_sexo.Text = string.Empty;
                    mtbCpf.Text = string.Empty;
                    txbDocumento.Text = string.Empty;
                    txbEndereco.Text = string.Empty;
                    txbBairro.Text = string.Empty;
                    txbCidade.Text = string.Empty;
                    txbEstado.Text = string.Empty;
                    txbProfissao.Text = string.Empty;
                    txbEmail.Text = string.Empty;
                    mtbCelular.Text = string.Empty;
                    mtbFixo.Text = string.Empty;
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

        private void FrmCadAdotante_Load(object sender, EventArgs e)
        {

        }

        private void FrmCadAdotante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class FrmAdocao : Form
    {
        public FrmAdocao()
        {
            InitializeComponent();
        }

        private void txbAnimal_Click(object sender, EventArgs e)
        {
            FrmBuscaAnimal fm = new FrmBuscaAnimal();
            fm.ShowDialog();
        }

        private void FrmAdocao_Load(object sender, EventArgs e)
        {
            cblSemana.Items.Add("SEGUNDA - FEIRA");
            cblSemana.Items.Add("TERÇA - FEIRA");
            cblSemana.Items.Add("QUARTA - FEIRA");
            cblSemana.Items.Add("QUINTA - FEIRA");
            cblSemana.Items.Add("SEXTA - FEIRA");
            cblSemana.Items.Add("SABADO");
        }

        private void btnBuscaAnimal_Click(object sender, EventArgs e)
        {
            string conString = "server=localhost; user=root; pwd=skill; database=AdoteUmPet;";
            MySqlConnection con = new MySqlConnection(conString);

            string query = "select * from animal where ani_nome = '"+ txbAnimal.Text+ "' ";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                if (txbAnimal.Text == string.Empty)
                {
                    throw new Exception("Você precisa buscar um animal");
                }

                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("Animal não cadastrado");
                }
                dr.Read();

                txbIdadePet.Text = Convert.ToString(dr["ani_idade"]);
                txbPorte.Text = Convert.ToString(dr["ani_porte"]);
                byte[] foto = (byte[])(dr["ani_foto"]);
                if(foto == null)
                {
                    pcbFoto.Image = null; 
                }
                else
                {
                    MemoryStream ms = new MemoryStream(foto);
                    pcbFoto.Image = Image.FromStream(ms);
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscaCpf_Click(object sender, EventArgs e)
        {
            string conString = "server=localhost; user=root; pwd=skill; database=AdoteUmPet;";
            MySqlConnection con = new MySqlConnection(conString);

            string query = "select * from adotante where adt_cpf = '" + mtbCpf.Text + "' ";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                if (mtbCpf.Text == string.Empty)
                {
                    throw new Exception("Você precisa buscar um adotante");
                }

                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("CPF não cadastrado");
                }
                dr.Read();
                
                txbNome.Text = Convert.ToString(dr["adt_nome"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string NomeAnimal = txbAnimal.Text;
            string IdadeAnimal = txbIdadePet.Text;
            string Cpf = mtbCpf.Text;
            string NomeAdotante = txbNome.Text;
            string Local = txbLocal.Text;
            string DataAdocao = mtbData.Text;
            string DiaVisita = cblSemana.SelectedItem.ToString();
            string Horario1 = mtbHorario1.Text;
            string Horario2 = mtbHorario2.Text;
            string Responsavel = txbResponsavel.Text;

            if (NomeAnimal == "" || Cpf == "   .   .   -")
            {
                MessageBox.Show(DiaVisita, "ERRO");
                MessageBox.Show("Você não pode deixar campo em branco!", "ERRO");
                return;
            }

            string conString = "server=localhost; user=root; pwd=skill; database=AdoteUmPet;";
            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                string query = "INSERT INTO adocao (adc_data, ani_nome, adt_cpf, adt_nome, adc_local, adc_dia_visita, "
                             + " adc_hora_visita1, adc_hora_visita2, usr_responsavel) "
                             + " VALUES ( '" + Convert.ToDateTime(DataAdocao).ToString("yyyy/MM/dd") + "', '" + NomeAnimal + "', '" + Cpf + "', '" + NomeAdotante + "', '" + Local + "', '" + DiaVisita + "', "
                             + " '" + Horario1 + "', '" + Horario2 + "', '" + Responsavel + "' )";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.ExecuteNonQuery();

                MessageBox.Show( NomeAnimal + " Recebeu um novo lar! ", "Adoção do " + NomeAnimal + " Registrada");

                txbAnimal.Text = string.Empty;
                txbIdadePet.Text = string.Empty;
                mtbCpf.Text = string.Empty;
                txbNome.Text = string.Empty;
                txbLocal.Text = string.Empty;
                mtbData.Text = string.Empty;
                cblSemana.Text = string.Empty;
                mtbHorario1.Text = string.Empty;
                mtbHorario2.Text = string.Empty;
                txbResponsavel.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao inserir os dados \n" + ex.Message + "\n Favor contactar o Suporte", "Erro de Conexão");
            }
        }

        private void cblSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbAnimal.Text = string.Empty;
            txbIdadePet.Text = string.Empty;
            mtbCpf.Text = string.Empty;
            txbNome.Text = string.Empty;
            txbLocal.Text = string.Empty;
            mtbData.Text = string.Empty;
            cblSemana.Text = string.Empty;
            mtbHorario1.Text = string.Empty;
            mtbHorario2.Text = string.Empty;
            txbResponsavel.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

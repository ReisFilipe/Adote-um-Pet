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
using System.Globalization;
using System.IO;

namespace Login
{
    public partial class FrmCadDog : Form
    {
        public FrmCadDog()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string Nome = txbNome.Text;
            string Raca = txbRaca.Text;
            string Cor = txbCor.Text;
            string Porte = txbPorte.Text;
            string Data = mtxbData.Text;
            string foto = txbImagen.Text.Replace(@"\", @"\\");

            if (Nome == "" || Raca == "" || Cor == "")
            {
                MessageBox.Show("Você não pode deixar campo em branco! " , "ERRO");
                return;
            }

            if (Data == "  /  /")
            {
                MessageBox.Show("Campo data em branco ! " + foto, "ERRO");
                return;
            }
            /*
            FileStream fs = new FileStream(this.txbImagen.Text, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            foto = br.ReadBytes((int)fs.Length);
            */


            string conString = "server=localhost; user=root; pwd=skill; database=AdoteUmPet;";
            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO animal (ani_nome, ani_raca, ani_cor, ani_porte, ani_data_entrada, ani_data_cadastro, ani_foto) "
                                                      + "VALUES ('" + Nome + "' , '" + Raca + "' , '" + Cor + "' , '" + Porte + "' , '" + Convert.ToDateTime(Data).ToString("yyyy/MM/dd") + "' , '" + DateTime.Now.ToString("yyyy-MM-dd") + "', REPLACE('" + foto+"' ", con);
                comando.ExecuteNonQuery();

                CopiarParaLocalDoAplicativo(foto, "Fotos");

                MessageBox.Show("Animal Registrado", "Animal Registrado");

                txbNome.Text = string.Empty;
                txbCor.Text = string.Empty;
                txbPorte.Text = string.Empty;
                txbRaca.Text = string.Empty;
                mtxbData.Text = string.Empty;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao inserir os dados \n" + ex.Message + "\n Favor contactar o Suporte", "Erro de Conexão");
            }
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadDog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);

            }
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string foto = dlg.FileName.ToString();
                txbImagen.Text = foto;
                pcbFoto.ImageLocation = foto;   
            } 


        }

        public bool CopiarParaLocalDoAplicativo(string Arquivo, string SubPasta)
        {
            try
            {
                string caminhoDoExecutavel = System.Reflection.Assembly.GetCallingAssembly().Location;
                string pastaDoExecutavel = new System.IO.FileInfo(caminhoDoExecutavel).DirectoryName;

                string nomeDoArquivo = Arquivo.Split(new char[] { '\\' })[Arquivo.Split(new char[] { '\\' }).Length - 1];

                string novoCaminhoArquivo;

                if (!string.IsNullOrEmpty(SubPasta))
                {
                    novoCaminhoArquivo = pastaDoExecutavel + @"\" + SubPasta + @"\" + nomeDoArquivo;
                }
                else
                {
                    novoCaminhoArquivo = pastaDoExecutavel + @"\" + nomeDoArquivo;
                }

                System.IO.File.Copy(Arquivo, novoCaminhoArquivo, true);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

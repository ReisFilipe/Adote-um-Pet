using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Login
{
    public class conexao
    {
        public MySqlConnection Create()
        {
            /*
            private string Server = "localhost";
            private string Database = "AdoteUmPet";
            private string Usuario = "root";
            private string Senha = "skill";
            */
            string conString = "server=localhost; user=root; pwd=skill; database=AdoteUmPet;";
            MySqlConnection con = new MySqlConnection(conString);

            con.Open();

            return con;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace App_Biblioteca
{
    class Conexao
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection cnn = new MySqlConnection(@"server=localhost;uid=root;pwd=;database=biblioteca;");

            return cnn;
        }
    }
}

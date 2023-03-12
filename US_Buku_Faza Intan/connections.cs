using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace US_Buku_Faza_Intan
{
    //koneksi adalah object dr mysql connection
    internal class connections
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection koneksi = null;
             
            try
            {
                string sConnstring = "server = localhost;database= db_buku;uid=root;password=;";
                koneksi = new MySqlConnection(sConnstring);
            }
            catch (MySqlException sqlex)
            {
                throw new Exception(sqlex.Message.ToString());
            }
            return koneksi;
        }
    }
}
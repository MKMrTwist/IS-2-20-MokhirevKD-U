using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace connectbd
{
    public class Conndb
    {
        string strConnect;
        MySqlConnection Conn;

        public MySqlConnection Connection()
        {
            Conn = new MySqlConnection(strConnect);
            return Conn;
        }
        public string ReturnConn()
        {
            return strConnect;
        }
        public Conndb(string connect)
        {
            strConnect = connect;
        }
    }
}

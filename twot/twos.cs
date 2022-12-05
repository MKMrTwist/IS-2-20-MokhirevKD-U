using MySql.Data.MySqlClient;
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

namespace twot
{
    public partial class twos : Form
    {
        public class ConnectDB
        {

            string sconn;

            public string ReturnConn()
            {
                return sconn;
            }
            public ConnectDB(string a)
            {
                sconn = a;
            }
        }
        ConnectDB connect = new ConnectDB("server=chuc.caseum.ru;port=33333;user=uchebka;database=uchebka;password=uchebka;");
        MySqlConnection my;
        public twos()
        {
            InitializeComponent();
        }
        private void twot_Load(object sender, EventArgs e)
        {
            my = new MySqlConnection(connect.ReturnConn());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                my.Open();
                MessageBox.Show("Подключено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы с подключением, причина ошибки:" + ex.Message);
            }
            finally
            {
                my.Close();
            }

        }
    
    }
}

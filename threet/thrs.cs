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

namespace threet
{
    public partial class thrs : Form
    {
        MySqlConnection Connection;
        connectbd Connect = new ConnectDB("server=chuc.caseum.ru;port=33333;username=st_2_20_18;password=;database=is_2_20_st18_KURS");
        MySqlDataAdapter MyDA = new MySqlDataAdapter();
        BindingSource BindingS = new BindingSource();
        DataTable DT = new DataTable();
        public void GetLyd()
        {
            DT.Clear();
            string sqlview = "SELECT Items.ID AS `Код`, Items.Title AS `Имя`, Type.title AS `Фамилия`, Items.Price AS `Дата рождения` FROM Items JOIN Type ON Items.Type_id = Type.id JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 2";
            Connection.Open();

            MyDA.SelectCommand = new MySqlCommand(sqlview, Connection);
            MyDA.Fill(DT);

            BindingS.DataSource = DT;

            dataGridView1.DataSource = BindingS;
            Connection.Close();

            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = true;



            dataGridView1.Columns[0].FillWeight = 15;
            dataGridView1.Columns[1].FillWeight = 15;
            dataGridView1.Columns[2].FillWeight = 15;
            dataGridView1.Columns[3].FillWeight = 15;
            dataGridView1.Columns[4].FillWeight = 15;


            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;


            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ColumnHeadersVisible = true;
        }
        public thrs()
        {
            InitializeComponent();
        }

        private void threet_Load(object sender, EventArgs e)
        {
            Connection = Connect.Connection();
            GetLyd();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            Connection.Open();
            string info1 = "";
            string info2 = "";
            string info3 = "";
            string info4 = "";
            string info5 = "";
            string info6 = "";
            string sql = $"SELECT Items.ID AS `код`, Manufacture.title AS `Имя`, Items.Title AS `Фамилия`, Type.title AS `Дата рождения`,Items. AS `Номер`, JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.ID = " + id;
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                info1 = reader[0].ToString();
                info2 = reader[1].ToString();
                info3 = reader[2].ToString();
                info4 = reader[3].ToString();
                info5 = reader[4].ToString();
                info6 = reader[5].ToString();
            }
            reader.Close();
            MessageBox.Show("Код: " + info1 + "\n" + "Имя: " + info2 + "\n" + "Фамиилия: " + info3 + "\n" + "Дата Рождения: " + info4 , MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onet
{
    public partial class onet : Form
    {
       abstract class compl<T>
        {
            public int Cost;
            public int Datey;
            public T Article;
            public compl(int cost, int datey, T article )
            {
                this.Cost = cost;
                Datey = datey;
                Article = article;
            }
            public virtual string Display()
            {
                return $"Цена:{Cost} \n Год выпуска:{Datey}";
            }
        }
        class HDD<T> : compl<T>
        {
            int Turnovers;
            public int Turn
            {
                get
                {
                    return Turnovers;
                }
                set
                {
                   Turnovers = value;
                }
            }
            string Cinterface;
            public string Connect
            {
                get
                {
                    return Cinterface;
                }
                set
                {
                    Cinterface = value;
                }
            }
            int Vol;
            public int vol
            {
                get
                {
                    return Vol;
                }
                set
                {
                    Vol = value;
                }
            }
            public HDD(int Cost, int Datey,T Art, int turnovers, string Cinterface, int Size) : base(Cost, Datey, Art)
            {
                Turn = turnovers;
                Connect = Cinterface;
                vol = Vol;
            }
            public override string Display()
            {
                return $"Цена: {Cost} \n Год: {Datey} \n Артикул:{Article}\n Скорость оборротов:{Turn} \n Интерфейс подключения:{Connect} \n Объем:{vol} ";
            }
        }
        class GPU<T> : compl<T>
        {
            double FGPU;
            public double F
            {
                get
                {
                    return FGPU;
                }
                set
                {
                    FGPU = value;
                }
            }
            string Manufacture;
            public string Maf
            {
                get
                {
                    return Manufacture;
                }
                set
                {
                    Manufacture = value;
                }
            }
            int SizeMemory;
            public int SMem
            {
                get
                {
                    return SizeMemory;
                }
                set
                {
                    SizeMemory = value;
                }
            }
            public GPU(int Cost, int Datey, T Art, double FGPU, string manufacture, int sizeMemory) : base(Cost, Datey, Art)
            {
                F = FGPU;
                Maf = manufacture;
                SMem = sizeMemory;
            }
            public override string Display()
            {
                return $"Цена: {Cost} \n Год выпуска: {Datey} \n Артикул: {Article}\n Частота Графического процессора: {F} \n Производитель: {Maf} \n Объем памяти: {SMem} ";
            }
        }
        HDD<int> hdd;
        GPU<int> gpu;
        public onet()
        {
            InitializeComponent();
        }

        private void onet_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                hdd = new HDD<int>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), textBox6.Text, Convert.ToInt32(textBox3.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(hdd.Display());
        }
        private void button4_Click(object sender, EventArgs e)
        {
           try
            {
                gpu = new GPU<int>(Convert.ToInt32(textBox12.Text), Convert.ToInt32(textBox12.Text), Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox7.Text), textBox8.Text, Convert.ToInt32(textBox9.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(gpu.Display());
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

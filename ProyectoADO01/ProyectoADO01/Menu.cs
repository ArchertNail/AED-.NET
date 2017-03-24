using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoADO01
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 proyect1 = new Form1();
            proyect1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 proyect2 = new Form2();
            proyect2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Practica03 practica03 = new Practica03();
            practica03.Show();
            this.Hide();
        }

        private void proyecto04_Click(object sender, EventArgs e)
        {
            Practica04 practica04 = new Practica04();
            practica04.Show();
            this.Hide();
        }
    }
}

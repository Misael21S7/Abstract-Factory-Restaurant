using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_Factory_Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestauranteFactory fabrica = null;

            if (comboBox1.SelectedIndex == 0)
            {
                fabrica = new RestauranteChinoFactory();
                textBox2.ForeColor = Color.Red;
                textBox2.Text = "Restaurante Chino";

                pictureBox1.Image = Properties.Resources.arroz_frito;
                pictureBox2.Image = Properties.Resources.te_de_jazmin;
                pictureBox3.Image = Properties.Resources.pastel_luna_mooncake_chocolate;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                fabrica = new RestauranteJaponesFactory();
                textBox2.ForeColor = Color.Blue;
                textBox2.Text = "Restaurante Japonés";

                pictureBox1.Image = Properties.Resources.sushi;
                pictureBox2.Image = Properties.Resources.sake;
                pictureBox3.Image = Properties.Resources.mochi_japones;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                fabrica = new RestauranteMexicanoFactory();
                textBox2.ForeColor = Color.Green;
                textBox2.Text = "Restaurante Mexicano";

                pictureBox1.Image = Properties.Resources.Tacos;
                pictureBox2.Image = Properties.Resources.horchata;
                pictureBox3.Image = Properties.Resources.churro;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                fabrica = new RestauranteItalianoFactory();
                textBox2.ForeColor = Color.DarkGreen;
                textBox2.Text = "Restaurante Italiano";

                pictureBox1.Image = Properties.Resources.pizza;
                pictureBox2.Image = Properties.Resources.espresso;
                pictureBox3.Image = Properties.Resources.tiramisu;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                fabrica = new RestauranteGriegoFactory();
                textBox2.ForeColor = Color.LightBlue;
                textBox2.Text = "Restaurante Griego";

                pictureBox1.Image = Properties.Resources.gyro;
                pictureBox2.Image = Properties.Resources.cafe;
                pictureBox3.Image = Properties.Resources.Baklava_Plato_Griego;
            }

            if (fabrica != null)
            {
                Cliente cliente = new Cliente(fabrica);

                textBox3.Text = cliente.ObtenerPlatillo();
                textBox4.Text = cliente.ObtenerBebida();
                textBox5.Text = cliente.ObtenerPostre();

                textBox2.Visible = true;

                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
            }
        }

        // Handler required by the designer: comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Minimal, safe implementation: reflect selected item in the results textbox if present.
            if (comboBox1 != null && textBox1 != null)
            {
                var selected = comboBox1.SelectedItem;
                textBox1.Text = selected != null ? selected.ToString() : string.Empty;
            }
        }
    }
}

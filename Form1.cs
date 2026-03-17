using System;
using System.Windows.Forms;

namespace Abstract_Factory_Restaurant
{
    public partial class Form1
    {
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Guard in case controls aren't initialized yet
            if (comboBox1 == null) return;

            // Clear previous results
            if (textBox1 != null) textBox1.Text = "Resultados del menu";
            if (textBox3 != null) textBox3.Clear();
            if (textBox4 != null) textBox4.Clear();
            if (textBox5 != null) textBox5.Clear();

            // Simple handling: display selected cuisine
            if (comboBox1.SelectedItem != null && textBox1 != null)
            {
                textBox1.Text = $"Cocina seleccionada: {comboBox1.SelectedItem}";
            }
        }
    }
}
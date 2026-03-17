using System;
using System.Windows.Forms;

namespace Abstract_Factory_Restaurant
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Text = "Seleccione una cocina:";
            // ❌ Quitamos el evento que causaba error

            // comboBox1
            this.comboBox1.Items.AddRange(new object[] {
                "Comida China",
                "Comida Japonesa",
                "Comida Mexicana",
                "Comida Italiana",
                "Comida Griega"});
            this.comboBox1.Location = new System.Drawing.Point(41, 57);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);

            // button1
            this.button1.Text = "Generar menu";
            this.button1.Location = new System.Drawing.Point(41, 109);
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // textboxes
            this.textBox3.Location = new System.Drawing.Point(14, 361);
            this.textBox4.Location = new System.Drawing.Point(221, 361);
            this.textBox5.Location = new System.Drawing.Point(428, 361);

            this.textBox2.Location = new System.Drawing.Point(-1, 568);
            this.textBox2.Text = "Menu generado correctamente";
            this.textBox2.TextAlign = HorizontalAlignment.Center;

            this.textBox1.Location = new System.Drawing.Point(41, 168);
            this.textBox1.Text = "Resultados del menu";
            this.textBox1.TextAlign = HorizontalAlignment.Center;

            // labels
            this.label2.Text = "Plato fuerte:";
            this.label2.Location = new System.Drawing.Point(54, 219);

            this.label3.Text = "Bebida:";
            this.label3.Location = new System.Drawing.Point(277, 219);

            this.label4.Text = "Postre:";
            this.label4.Location = new System.Drawing.Point(485, 219);

            // panel
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);

            this.panel2.Location = new System.Drawing.Point(21, 12);
            this.panel2.Size = new System.Drawing.Size(636, 599);

            // Form
            this.ClientSize = new System.Drawing.Size(675, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Text = "Comida Factory - Generador de Menus";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
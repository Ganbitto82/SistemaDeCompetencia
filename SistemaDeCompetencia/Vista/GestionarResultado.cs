using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaDeCompetencia.Vista
{
    public partial class GestionarResultado : Form
    {
        public GestionarResultado()
        {
            InitializeComponent();
            label14.Text = textBox1.Text;
            label12.Text = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox3.Visible = true;
            label14.Visible = false;
            label12.Visible = false;
            label16.Visible = false;
            label9.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            button_cancelar.Visible = true;
            button1.Visible = false;
            button9.Visible = false;
            button8.Visible = true;

            textBox2.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;

            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;
            textBox15.Visible = true;
            textBox16.Visible = true;
            textBox17.Visible = true;
            textBox18.Visible = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label14.Text = textBox1.Text;
            label12.Text = textBox3.Text;
            label14.Visible = true;
            label12.Visible = true;
            textBox1.Visible = false;
            textBox3.Visible = false;
            label16.Visible = true;
            label9.Visible = false;

            textBox2.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;

            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;


            button_cancelar.Visible = false;
            button1.Visible = true;
            button9.Visible = true;
            button8.Visible = false;


            checkBox1.Visible = false;
            checkBox2.Visible = false;

            if (checkBox1.Checked == false) label17.Visible = false;
            if (checkBox2.Checked == false) label18.Visible = false;

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            label14.Visible = true;
            label12.Visible = true;
            textBox1.Visible = false;
            textBox3.Visible = false;
            label16.Visible = true;
            label9.Visible = false;
            if (checkBox1.Checked == false) label17.Visible = false;
            if (checkBox2.Checked == false) label18.Visible = false;


            checkBox1.Visible = false;
            checkBox2.Visible = false;

            button_cancelar.Visible = false;
            button1.Visible = true;
            button9.Visible = true;
            button8.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void GestionarResultado_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeCompetencia.Vista
{
    public partial class MostrarFixture : Form
    {
        public MostrarFixture()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            button17.Enabled = true;
            button18.Enabled = false;
            panel5.Visible = false;
            panel12.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Enabled = false;
            button18.Enabled = true;
            panel5.Visible = true;
            panel12.Visible = false;
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button8.Text = button1.Text;
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel13.Visible = true;
            panel4.Visible = false;
            //button10.Enabled = true;
            //button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel13.Visible = false;
            panel4.Visible = true;
            //button10.Enabled = false;
            //button9.Enabled = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MostrarFixture frm = new MostrarFixture();

            this.Hide();
            frm.ShowDialog();
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button8.Text = button2.Text;
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button8.Text = button3.Text;
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //button8.Text = button5.Text;
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //button8.Text = button6.Text;
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //button8.Text = button7.Text;
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel16.Visible = false;
            button18.Enabled = true;
        }
    }

}

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
using SistemaDeCompetencia.Modelo;

namespace SistemaDeCompetencia.Vista

{
    public partial class DarAltaCompetencia : Form
    {
        private string permiso;
        private string formaDePuntuacion;
        public DarAltaCompetencia()
        {
            
            InitializeComponent();
            cargarModalidad();
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_modalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            string modalidad =  comboBox_modalidad.SelectedItem.ToString();
            Console.WriteLine("El indicador es : " + comboBox_modalidad.SelectedItem);
            controlModalidad(modalidad);
            
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            string nombreCompetencia = textBox_nombre.Text;
            string deporteElegido = comboBox_deporte.SelectedText;
            int indice = TablaLugares.CurrentRow.Index;
            string lugar = TablaLugares.Rows[indice].Cells[0].Value.ToString();
            int disponibilidad= (int)TablaLugares.Rows[indice].Cells[1].Value;

             
           
            
            //  MessageBox.Show("Mensaje de informacion","Titulo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLugarDeRealizacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown_partGanados_ValueChanged(object sender, EventArgs e)
        {

        }
        private void controlModalidad(string modalidad)
        {
            numericUpDown_partGanados.Enabled = false;
            numericUpDown_presencia.Enabled = false;
            numericUpDown_partEmpatados.Enabled = false;
            numericUpDown_tantos.Enabled = false;
            comboBox_permiso.Enabled = false;
            comboBox_formaPutuacion.Enabled=false;

            switch (modalidad) {
                case "SISTEMA_DE_LIGA":
                    numericUpDown_partGanados.Enabled = true;
                    comboBox_permiso.Enabled = true;
                    numericUpDown_presencia.Enabled = true;
                    comboBox_formaPutuacion.Enabled = true;
                    numericUpDown_partGanados.Value = 0;
                    numericUpDown_presencia.Value = 0;
                    comboBox_permiso.Text = "--Seleccione--";
                    comboBox_formaPutuacion.Text = "--Seleccione--";
                    break;
                case "SISTEMA_DE_ELIMINACION_DOBLE":
                    numericUpDown_partGanados.Enabled = true;
                    numericUpDown_presencia.Enabled = true;
                    comboBox_permiso.Enabled = false;
                    comboBox_formaPutuacion.Enabled = true;
                    numericUpDown_partGanados.Value = 0;
                    numericUpDown_presencia.Value = 0;
                    comboBox_permiso.Text = "--Seleccione--";
                    comboBox_formaPutuacion.Text = "--Seleccione--";

                    break;
                case "SISTEMA_DE_ELIMINACION_SIMPLE":
                    numericUpDown_partGanados.Enabled = true;
                    numericUpDown_presencia.Enabled = true;
                    comboBox_permiso.Enabled = false;
                    comboBox_formaPutuacion.Enabled = true;
                    numericUpDown_partGanados.Value = 0;
                    numericUpDown_presencia.Value = 0;
                    comboBox_permiso.Text = "--Seleccione--";
                    comboBox_formaPutuacion.Text = "--Seleccione--";

                    break;
            }
        }
        private void cargarModalidad() {
            comboBox_modalidad.Items.Add(Modalidad.SISTEMA_DE_LIGA);
            comboBox_modalidad.Items.Add(Modalidad.SISTEMA_DE_ELIMINACION_DOBLE);
            comboBox_modalidad.Items.Add(Modalidad.SISTEMA_DE_ELIMINACION_SIMPLE);
             }

        private void numericUpDown_presencia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_partEmpatados_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_permiso_SelectedIndexChanged(object sender, EventArgs e)
        {
            permiso = comboBox_permiso.SelectedItem.ToString();
            if (permiso == "SI")
                numericUpDown_partEmpatados.Enabled = true;
            else
            {
                numericUpDown_partEmpatados.Enabled = false;
                numericUpDown_partEmpatados.Value = 0;
            }
        }

        private void comboBox_formaPutuacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            formaDePuntuacion = comboBox_formaPutuacion.SelectedItem.ToString();
            if (formaDePuntuacion == "SETS")
            {
                numericUpDown_sets.Enabled = true;
                numericUpDown_tantos.Enabled = false;
                numericUpDown_tantos.Value = 0;
            }

            else
            {
                numericUpDown_sets.Enabled = false;
                numericUpDown_tantos.Enabled = true;
                numericUpDown_sets.Value = 0;
            }
        }
    }
}

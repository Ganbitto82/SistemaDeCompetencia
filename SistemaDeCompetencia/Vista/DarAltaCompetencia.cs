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
using SistemaDeCompetencia.Dto;
using SistemaDeCompetencia.Controladores;
using SistemaDeCompetencia.Modelo;

namespace SistemaDeCompetencia.Vista

{
    public partial class DarAltaCompetencia : Form
    {
        // OleDbConnection conexion;
        DtoUsuario dtoUsuarioForm = new DtoUsuario();
        private GestorCompetencia gComp = new GestorCompetencia();
        private List<DtoDeporte> listaDeporte;
        private List<DtoLugarDeRealizacion> listaDtoLugares;
        private List<DtoDisponibilidad> listaDtoDisponibilidad;
        private int valorDisponibilidad;



        private string deporteSeleccionado;
        private DtoDeporte dtoDeporte;


        public DarAltaCompetencia(DtoUsuario dtoUsuario)
        {
            dtoUsuarioForm = dtoUsuario;
            /*
            GestorCompetencia gestorCompetencia = new GestorCompetencia();
            List<DtoDeporte> listaDtoDeportes = gestorCompetencia.listarDeportes(dtoUsuario.DtoUsuarioId);
            List<String> nombreDeportes = new List<string>();
            foreach (var deporte in listaDtoDeportes)
            {
                nombreDeportes.Add(deporte.Nombre);
            }
            */
            InitializeComponent();
            //comboBox_deporte.Items.Add(nombreDeportes);
            cargarModalidad();
            cargarDeportes();
           


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

            string modalidad = comboBox_modalidad.SelectedItem.ToString();
            controlModalidad(modalidad);

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {

            DtoCompetencia dtoCompetencia = new DtoCompetencia();
            DtoLugarDeRealizacion dtoLugarDeRealizacion = new DtoLugarDeRealizacion();
            // dtoLugarDeRealizacion

            dtoCompetencia.Nombre = textBox_nombre.Text.ToUpper();
            dtoCompetencia.DtoDeporte = dtoDeporte;




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
             



        private void TablaLugares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void comboBox_deporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            deporteSeleccionado = comboBox_deporte.SelectedItem.ToString();

            int deporteId = 0;
            foreach (var deporte in listaDeporte)
            {
                if (deporte.Nombre == deporteSeleccionado)
                {
                    deporteId = deporte.DeporteId;
                    dtoDeporte = deporte;
                }
            }
            listaDtoLugares = gComp.listarLugares(deporteId, dtoUsuarioForm.DtoUsuarioId );
            
            TablaLugares.Rows.Clear();
            cargarTabla(listaDtoLugares);
           
        }

        
        private void cargarTabla(List<DtoLugarDeRealizacion> listaDtoLugares)
        {
            foreach (var lugar in listaDtoLugares) 
            { 
            int n= TablaLugares.Rows.Add();
            TablaLugares.Rows[n].Cells[0].Value = lugar.Nombre;
            }
        }
        private void cargarDisponibilidad(List<DtoLugarDeRealizacion> listaLugares )
        {
          
            foreach (var lugar in listaLugares)
            {
                DtoDisponibilidad dtoDisponibilidad = new DtoDisponibilidad();

                dtoDisponibilidad.LugarId = lugar.LugarId;
               // dtoDisponibilidad.Disponible = valorDisponibilidad;
                //listaDtoDisponibilidad.Add(dtoDisponibilidad);
               
            }
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

            switch (modalidad)
            {
                case "SISTEMA_DE_LIGA":
                    numericUpDown_partGanados.Enabled = true;
                    comboBox_permiso.Enabled = true;
                    numericUpDown_presencia.Enabled = true;
                    comboBox_formaPutuacion.Enabled = true;
                    numericUpDown_partGanados.Value = 0;
                    numericUpDown_presencia.Value = 0;
                    numericUpDown_tantos.Value = 0;
                    numericUpDown_sets.Value = 0;
                    comboBox_permiso.Text = "--Seleccione--";
                    comboBox_formaPutuacion.Text = "--Seleccione--";
                    break;
                case "SISTEMA_DE_ELIMINACION_DOBLE":
                    numericUpDown_partGanados.Enabled = true;
                    numericUpDown_presencia.Enabled = true;
                    comboBox_permiso.Enabled = false;
                    comboBox_formaPutuacion.Enabled = true;
                    numericUpDown_partEmpatados.Value = 0;
                    numericUpDown_partGanados.Value = 0;
                    numericUpDown_presencia.Value = 0;
                    numericUpDown_tantos.Value = 0;
                    numericUpDown_sets.Value = 0;
                    comboBox_permiso.Text = "--Seleccione--";
                    comboBox_formaPutuacion.Text = "--Seleccione--";

                    break;
                case "SISTEMA_DE_ELIMINACION_SIMPLE":
                    numericUpDown_partGanados.Enabled = true;
                    numericUpDown_presencia.Enabled = true;
                    comboBox_permiso.Enabled = false;
                    numericUpDown_partGanados.Value = 0;
                    comboBox_formaPutuacion.Enabled = true;
                    numericUpDown_partGanados.Value = 0;
                    numericUpDown_presencia.Value = 0;
                    numericUpDown_tantos.Value = 0;
                    numericUpDown_sets.Value = 0;
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

        private void cargarDeportes()
        {
            listaDeporte = gComp.listarDeportes();
            foreach(var deporte in listaDeporte)
            {
                comboBox_deporte.Items.Add(deporte.Nombre);
            }

        }

        private void numericUpDown_presencia_ValueChanged(object sender, EventArgs e)
        {

        }


        private void Cancelar_Click(object sender, EventArgs e)
        {
            Form frmListarComp = new ListarCompetencia(dtoUsuarioForm);
            frmListarComp.Show();
            this.Close();
        }

        private void numericUpDown_partEmpatados_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_permiso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string permiso = comboBox_permiso.SelectedItem.ToString();
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
          string formaDePuntuacion = comboBox_formaPutuacion.SelectedItem.ToString();
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
        private bool validarNumero(string numero)
        {
            //Obtenemos la longitud del numero 
            int cantidad = numero.Length;
            for (int i = 0; i != cantidad; ++i)
            {
                //Detectamos si el numero es solo entero 
                if (!(numero[i] >= '0' && numero[i] <= '9'))
                    return true;
            }
            return false;
        }
        private void TablaLugares_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            DataGridViewTextBoxCell cell = TablaLugares[1, e.RowIndex] as DataGridViewTextBoxCell;
            //Si es la columna de disponibilidad y  es un número, la condición se cumple.

            {
                if (e.ColumnIndex == 1 && validarNumero(e.FormattedValue.ToString()))
                {
                    e.Cancel = true;
                    TablaLugares.Rows[e.RowIndex].ErrorText = "Solo se puede ingresar números y no puede ser vacio";
                }
                else
                {

                    //string valor = e.FormattedValue.ToString();

                    // cargarDisponibilidad(listaDtoLugares);


                }

            }
        }
        
        private void TablaLugares_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //Borra el mensaje de error cuando la validación termine...
            TablaLugares.Rows[e.RowIndex].ErrorText = "     ";
        }

    }
}

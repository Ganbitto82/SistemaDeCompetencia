using SistemaDeCompetencia.Controladores;
using SistemaDeCompetencia.Dto;
using SistemaDeCompetencia.Modelo;
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
    
    public partial class ListarCompetencia : Form
    {
        private GestorCompetencia gestorCompetencia = new GestorCompetencia();
        DtoUsuario dtoUsuarioForm = new DtoUsuario();
        private List<DtoDeporte> listaDeporte = new List<DtoDeporte>();
        private List<DtoCompetencia> listaDtoCompetencia = new List<DtoCompetencia>();

        public ListarCompetencia(DtoUsuario dtoUsuario)
        {
     
            dtoUsuarioForm = dtoUsuario;
            
            InitializeComponent();
            cargarDeportes();
            cargarModalidad();

        }
        private void cargarModalidad()
        { //carga en el comboBox las modalidades
            comboBox_modalidad.Text = "--Seleccione--";
            comboBox_modalidad.Items.Add(Modalidad.SISTEMA_DE_LIGA);
            comboBox_modalidad.Items.Add(Modalidad.SISTEMA_DE_ELIMINACION_SIMPLE);
            comboBox_modalidad.Items.Add(Modalidad.SISTEMA_DE_ELIMINACION_DOBLE);
        }
        private void cargarDeportes()

        { //funcion que carga los deportes en el comboBox

            listaDeporte = gestorCompetencia.listarDeportes();
            comboBox_deporte.Text = "--Seleccione--";
            foreach (var deporte in listaDeporte)
            {
                comboBox_deporte.Items.Add(deporte.Nombre);
            }

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Competicion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string modalidad;
            string deporte;
            string estado;
            
            string nombre= textBox_nombre.Text.ToUpper();

            if (comboBox_modalidad.SelectedItem == null)
            {
                modalidad = "";
            }
            else
            {
                modalidad = comboBox_modalidad.SelectedItem.ToString();
            }
            if (comboBox_deporte.SelectedItem == null)
            {
                deporte = "";
             }
            else 
            {
                deporte = comboBox_deporte.SelectedItem.ToString();
            }
            if (comboBox_estado.SelectedItem == null)
            {
                estado = "";
            }
            else 
            {
                estado = comboBox_estado.SelectedItem.ToString();

            }

            if (nombre.Equals("") && modalidad.Equals("") && deporte.Equals("") && estado.Equals(""))
            {
                MessageBox.Show("Debe ingresar al menos uno de los criterios de búsqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            { 
               listaDtoCompetencia = gestorCompetencia.FiltrarCompetencias(nombre,estado,modalidad,deporte);
               tablaDeCompetencias.Rows.Clear();
               cargarTabla(listaDtoCompetencia);

            }
           
                
           
            listaDtoCompetencia.Clear();
            

        }
        private void cargarTabla(List<DtoCompetencia> listaDtoCompetencia)
        {
            //carga los lugares en la tabla (columna Lugar)
            int n;
            foreach (var competencia in listaDtoCompetencia)
            {
                n= tablaDeCompetencias.Rows.Add();
                tablaDeCompetencias.Rows[n].Cells[0].Value = competencia.Nombre;
                tablaDeCompetencias.Rows[n].Cells[1].Value = competencia.DtoDeporte.Nombre;
                tablaDeCompetencias.Rows[n].Cells[2].Value = competencia.Modalidad;
                tablaDeCompetencias.Rows[n].Cells[3].Value = competencia.Estado;
            }
        
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Form frmPantallaPrincipal = new PantallaPrincipal(dtoUsuarioForm);
            frmPantallaPrincipal.Show();
            this.Close();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Form frmPantallaPrincipal = new PantallaPrincipal(dtoUsuarioForm);
            frmPantallaPrincipal.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form frmPantallaPrincipal = new PantallaPrincipal(dtoUsuarioForm);
            frmPantallaPrincipal.Show();
            this.Close();

        }

        private void button_nueva_Click(object sender, EventArgs e)
        {
            Form frmDarAltaComp = new DarAltaCompetencia(dtoUsuarioForm);
            frmDarAltaComp.Show();
            this.Close();
        }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_deporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       
        private void comboBox_modalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tablaDeCompetencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

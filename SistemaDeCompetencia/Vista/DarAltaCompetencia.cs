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
using System.Runtime.InteropServices.WindowsRuntime;

namespace SistemaDeCompetencia.Vista

{
    public partial class DarAltaCompetencia : Form
    {
        // OleDbConnection conexion;
        DtoUsuario dtoUsuarioForm = new DtoUsuario();
        private GestorCompetencia gComp = new GestorCompetencia();
        private List<DtoDeporte> listaDeporte = new List<DtoDeporte>();
        private List<DtoLugarDeRealizacion> listaDtoLugares = new List<DtoLugarDeRealizacion>();
        private List<DtoDisponibilidad> listaDtoDisponibilidad = new List<DtoDisponibilidad>();
        private List<int> valoresDeDisponibilidades = new List<int>();
        private string nombreCompentencia;
        private string modalidad;
        private Modalidad modalidadDto;
        private string deporteSeleccionado;
        private DtoDeporte dtoDeporte;
        private List<string> listaErrores = new List<string>();


        public DarAltaCompetencia(DtoUsuario dtoUsuario)
        {
            dtoUsuarioForm = dtoUsuario;
            InitializeComponent();
            cargarModalidad();
            cargarDeportes();
            
        }
        
        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        { 
           //carga el nombre  de la compencia ingresado
           nombreCompentencia = textBox_nombre.Text.ToUpper();
        }
        private void textBox_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //valida caracter por caracter que se ingresa si es un letra 
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void cargarDeportes()
        { //funcion que carga los deportes en el comboBox 
            listaDeporte = gComp.listarDeportes();
            comboBox_deporte.Text = "--Seleccione--";
            foreach (var deporte in listaDeporte)
            {
                comboBox_deporte.Items.Add(deporte.Nombre);
            }

        }
        private void comboBox_deporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selecciona un deporte y busca los lugares que le corresponde
            
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
            //busca los lugares
            listaDtoLugares = gComp.listarLugares(deporteId, dtoUsuarioForm.DtoUsuarioId);

            TablaLugares.Rows.Clear();
            cargarTabla(listaDtoLugares);

        }
              private void cargarTabla(List<DtoLugarDeRealizacion> listaDtoLugares)
        {
            //carga los lugares en la tabla (columna Lugar)
            foreach (var lugar in listaDtoLugares)
            {
                int n = TablaLugares.Rows.Add();
                TablaLugares.Rows[n].Cells[0].Value = lugar.Nombre;
               
            }
            TablaLugares.ClearSelection();
        }
        private void cargarModalidad()
        { //carga en el comboBox las modalidades
            comboBox_modalidad.Text = "--Seleccione--";
            comboBox_modalidad.Items.Add(Modalidad.SISTEMA_DE_LIGA);
            comboBox_modalidad.Items.Add(Modalidad.SISTEMA_DE_ELIMINACION_SIMPLE);
            comboBox_modalidad.Items.Add(Modalidad.SISTEMA_DE_ELIMINACION_DOBLE);
        }
        private void comboBox_modalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            modalidad = comboBox_modalidad.SelectedItem.ToString();
            
            controlModalidad(modalidad);

        }
     
        private void controlModalidad(string modalidad)
        {
            //funcion que activa los controles que le corresponde según la modalidad
            numericUpDown_partGanados.Enabled = false;
            numericUpDown_presencia.Enabled = false;
            numericUpDown_partEmpatados.Enabled = false;
            numericUpDown_tantos.Enabled = false;
            comboBox_permiso.Enabled = false;
            comboBox_formaPutuacion.Enabled = false;
            numericUpDown_partGanados.Value = 0;
            numericUpDown_presencia.Value = 0;
            numericUpDown_tantos.Value = 0;
            numericUpDown_sets.Value = 0;
            numericUpDown_partEmpatados.Value = 0;
            comboBox_permiso.Text = "--Seleccione--";
            comboBox_formaPutuacion.Text = "--Seleccione--";
            comboBox_permiso.Text = "--Seleccione--";
            comboBox_formaPutuacion.Text = "--Seleccione--";

            switch (modalidad)
            {
                case "SISTEMA_DE_LIGA":
                    numericUpDown_partGanados.Enabled = true;
                    comboBox_permiso.Enabled = true;
                    numericUpDown_presencia.Enabled = true;
                    comboBox_formaPutuacion.Enabled = true;
                    modalidadDto = Modalidad.SISTEMA_DE_LIGA;

                    break;
                case "SISTEMA_DE_ELIMINACION_DOBLE":
                    numericUpDown_partGanados.Enabled = true;
                    numericUpDown_presencia.Enabled = true;
                    comboBox_formaPutuacion.Enabled = true;
                    modalidadDto = Modalidad.SISTEMA_DE_ELIMINACION_DOBLE;

                    break;
                case "SISTEMA_DE_ELIMINACION_SIMPLE":
                    numericUpDown_partGanados.Enabled = true;
                    numericUpDown_presencia.Enabled = true;
                    comboBox_formaPutuacion.Enabled = true;
                    modalidadDto = Modalidad.SISTEMA_DE_ELIMINACION_SIMPLE;
                    break;
            }
        }

        private bool validarCampoSets() 
        {
         //funcion queverifica que la cantidad máxima de sets no es numrero impar o es número mayor a 10
            if (numericUpDown_sets.Value % 2 != 0 && numericUpDown_sets.Value < 10)
                return true;
            else
                return false;
        }
        private bool validarPuntos() 
        {
         //funcion que verifica que la cantidad de puntos por partido ganado es menor que la cantidad de punto por partido empatado
            
            
                if (numericUpDown_partGanados.Value < numericUpDown_partEmpatados.Value)
                    return false;
                else
                    return true;
           
        }
        private bool validarPuntosPorPresentarse() 
        {
            //La cantidad de puntos por partido ganado es menor que la cantidad de puntos por partido empatado.
            if (numericUpDown_presencia.Value >= numericUpDown_partGanados.Value)
                return false;
            else
                return true;
        }
        private void numericUpDown_partGanados_ValueChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown_presencia_ValueChanged(object sender, EventArgs e)
        {

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
            if (formaDePuntuacion == "RESULTADO FINAL") 
            {
                numericUpDown_tantos.Enabled = false;
                numericUpDown_sets.Enabled = false;
                numericUpDown_sets.Value = 0;
                numericUpDown_tantos.Value = 0;
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

        { //Si es la columna de disponibilidad y  es un número, la condición se cumple.
            Point c = TablaLugares.CurrentCellAddress;
            try
            {
                if (!TablaLugares.Rows[e.RowIndex].IsNewRow) 
                {
                    if (c.X == 1)
                    {
                        if (validarNumero(e.FormattedValue.ToString()))
                        {

                            e.Cancel = true;
                            TablaLugares.Rows[e.RowIndex].ErrorText = "Solo se permite el ingreso de valores numéricos";
                        }

                    }
                   
                }
            }
            catch (Exception)
            {
               // MessageBox.Show("Debe ingresar un valor numérico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void TablaLugares_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            // Clear any error messages that may have been set in cell validation.
            TablaLugares.Rows[e.RowIndex].ErrorText = String.Empty;
            
        }

        private bool verificarColumnaDisponibilidad() 
        {
          // funcion que verifica si en la columna dispinibilidad no haya ningun valor nulo 
            int filas = listaDtoLugares.Count();
            bool r = true;
            for(int i=0; i<filas; i++) 
            {
                if (TablaLugares.Rows[i].Cells[1].Value == null)
                {
                    r = false;
                    break;
                }
            }

            return r;
        }
      
        private bool cargarValoresDisponibilidad()
        {           
            string valor;
            int valorEntero;

            if (verificarColumnaDisponibilidad()==false)
            {
               // MessageBox.Show("Debe cargar con los valores numéricos de la columna disponibilidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                int posicion = 0;
                foreach (DataGridViewRow row in TablaLugares.Rows)
                {
                    valor = row.Cells["Disponibilidad"].Value.ToString();
                    valorEntero = int.Parse(valor);
                    
                    DtoDisponibilidad dtoDisponibilidad = new DtoDisponibilidad();
                    dtoDisponibilidad.Disponible = valorEntero;
                    dtoDisponibilidad.LugarId = listaDtoLugares.ElementAt(posicion).LugarId;
                    listaDtoDisponibilidad.Add(dtoDisponibilidad);
                    posicion++;
                                   
                }
                return true;
            }
        }
        private void Aceptar_Click(object sender, EventArgs e)
        {
            bool verificacionDeNombre;
            bool permisoEmpate = false;
            bool permisoParaCrearCompetencia = true;
        

            if (nombreCompentencia == null)
            {
                permisoParaCrearCompetencia = false;
                listaErrores.Add("Debe ingresar un nombre para la competencia");
                //MessageBox.Show("Debe ingresar un nombre para la competencia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
            else
                verificacionDeNombre = gComp.nombreEnUso(nombreCompentencia);

            if (deporteSeleccionado == null)
            {
                permisoParaCrearCompetencia = false;
                listaErrores.Add("Debe seleccionar un deporte");
                //MessageBox.Show("Debe seleccionar un deporte", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
               
            else 
            {
              
                if (cargarValoresDisponibilidad() == false)
                {
                    permisoParaCrearCompetencia = false;
                    listaErrores.Add("Debe cargar las disponibilidades");
                    //MessageBox.Show("Debe cargar las disponibilidades", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    
             }

            if (modalidad == null)
            {
                permisoParaCrearCompetencia = false;
                listaErrores.Add("Debe seleccionar una modalidad");
                //MessageBox.Show("Debe seleccionar una modalidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                

            else 
            {

                if (modalidad.Equals("SISTEMA_DE_LIGA"))
                {


                    if (comboBox_permiso.SelectedItem == null)
                    {
                        permisoParaCrearCompetencia = false;
                        listaErrores.Add("Debe seleccionar si permite empate");
                       // MessageBox.Show("Debe seleccionar si permite empate ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                    }

                        
                    else
                    {
                        if (comboBox_permiso.SelectedItem.ToString() == "SI")
                        {
                            if (validarPuntos() == false)
                            {
                                permisoParaCrearCompetencia = false;
                                listaErrores.Add("La cantidad de puntos por partidos ganado NO debe ser menor que la cantidad de puntos por partido empatados");
                                //MessageBox.Show("La cantidad de puntos por partidos ganado NO debe ser menor que la cantidad de puntos por partido empatados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                                
                            permisoEmpate = true;
                        }

                            
                    }
                    if (validarPuntosPorPresentarse() == false)
                    {
                        permisoParaCrearCompetencia = false;
                        listaErrores.Add("Los puntos por presentarse deben ser menor a la cantidad de puntos por partidos ganado");
                        //MessageBox.Show("Los puntos por presentarse deben ser menor a la cantidad de puntos por partidos ganado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (comboBox_formaPutuacion.SelectedItem == null)
                {
                    permisoParaCrearCompetencia = false;
                    listaErrores.Add("Debe seleccionar forma de puntuacion ");
                    //MessageBox.Show("Debe seleccionar forma de puntuacion ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                   
                else
                {
                    if (comboBox_formaPutuacion.SelectedItem.ToString() == "SETS")

                    {
                        if (validarCampoSets() == false)
                        {
                            permisoParaCrearCompetencia = false;
                            listaErrores.Add("La cantidad máxima de un sets debe ser número impar o debe ser un númro menor a 10");
                           // MessageBox.Show("La cantidad máxima de un sets debe ser número impar o debe ser un númro menor a 10", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                            
                    }
                }

                
            }
            if (listaErrores.Count != 0)
            {
                var mensajeDeErrores = string.Join(Environment.NewLine, listaErrores);
                MessageBox.Show(mensajeDeErrores, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listaErrores.Clear();
            }

            if (permisoParaCrearCompetencia)
            {
                //creamos el dtoCompetencia y seteamos sus atributos
                DtoCompetencia dtoCompetencia = new DtoCompetencia();
                DtoLugarDeRealizacion dtoLugarDeRealizacion = new DtoLugarDeRealizacion();

                //cargar usuario	
                dtoCompetencia.DtoUsuario = dtoUsuarioForm;
                dtoCompetencia.UsuarioId = dtoUsuarioForm.DtoUsuarioId;

                //seteamos el nombre
                dtoCompetencia.Nombre = textBox_nombre.Text.ToUpper();

                //cargamos deporte 	
                dtoCompetencia.DtoDeporte = dtoDeporte;
                //disponibilidades 	
                dtoCompetencia.Disponibilidades = listaDtoDisponibilidad;
                /* ver como se hace con la modalidad*/
                dtoCompetencia.Modalidad = modalidadDto;

                dtoCompetencia.PuntosPorPartidosGanado = Convert.ToInt32(numericUpDown_partGanados.Value);
                dtoCompetencia.PermisoDeEmpate = permisoEmpate;
                dtoCompetencia.PuntosPorPartidoEmpatado = Convert.ToInt32(numericUpDown_partEmpatados.Value);
                dtoCompetencia.PuntosPorPresentarse = Convert.ToInt32(numericUpDown_presencia.Value);

                /* MessageBox.Show("Mensaje de informacion","Titulo",MessageBoxButtons.OK,MessageBoxIcon.Information);*/
                //forma de puntuacion
                if (comboBox_formaPutuacion.SelectedItem != null && comboBox_formaPutuacion.SelectedItem.ToString().Equals("SETS"))
                {
                    DtoSet f = new DtoSet();
                    f.Cantidad = Convert.ToInt32(numericUpDown_sets.Value);
                    dtoCompetencia.DtoFormaDePuntuacion = f;
                }
                else if (comboBox_formaPutuacion.SelectedItem != null && comboBox_formaPutuacion.SelectedItem.ToString().Equals("PUNTUACION"))
                {
                    DtoPuntuacion f = new DtoPuntuacion();
                    f.TantosOtorgados = Convert.ToInt32(numericUpDown_tantos.Value);
                    dtoCompetencia.DtoFormaDePuntuacion = f;
                }
                else if (comboBox_formaPutuacion.SelectedItem != null && comboBox_formaPutuacion.SelectedItem.ToString().Equals("RESULTADO FINAL"))
                {
                    DtoResultadoFinal f = new DtoResultadoFinal();
                    dtoCompetencia.DtoFormaDePuntuacion = f;
                }
                //reglamento
                dtoCompetencia.Reglamento = textBoxReglamento.Text;


                GestorCompetencia gestorCompetencia = new GestorCompetencia();
                try
                {
                    dtoCompetencia=gestorCompetencia.darDeAltaCompetenciaDeporiva(dtoCompetencia);
                    
                    MessageBox.Show("La competencia fué dada de alta con éxito.", "Competencia Creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /*Form frmListarComp = new ListarCompetencia(dtoUsuarioForm);
                    frmListarComp.Show();
                    this.Close();*/
                    Form frmListarParticipante = new ListarParticipante(dtoCompetencia,dtoUsuarioForm);
                    frmListarParticipante.Show();
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "No se pudo completar la operacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }
        private void Cancelar_Click(object sender, EventArgs e)
        {
            Form frmListarComp = new ListarCompetencia(dtoUsuarioForm);
            frmListarComp.Show();
            this.Close();
        }

        private void numericUpDown_sets_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DarAltaCompetencia_Load(object sender, EventArgs e)
        {

        }

       

        private void textBoxReglamento_TextChanged(object sender, EventArgs e)
        {
           // textBoxReglamento.Text = "   ";

        }

        private void TablaLugares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


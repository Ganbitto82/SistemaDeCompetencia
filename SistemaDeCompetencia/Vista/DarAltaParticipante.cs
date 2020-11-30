using SistemaDeCompetencia.Controladores;
using SistemaDeCompetencia.Dto;
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
    public partial class DarAltaParticipante : Form
    {
        private DtoCompetencia dtocompetencia = new DtoCompetencia();
        private DtoUsuario dtoUsuario = new DtoUsuario();

        private GestorCompetencia gestorCompetencia= new GestorCompetencia();
        public DarAltaParticipante(DtoCompetencia dtoCompetencia,DtoUsuario dtoUsuarioForm)
        {
            dtoUsuario = dtoUsuarioForm;
            dtocompetencia = dtoCompetencia;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_deporte_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            DtoParticipante dtoParticipante = new DtoParticipante();
            dtoParticipante.Nombre = textBox_nombre.Text.ToUpper();
            dtoParticipante.CorreoElectronico = textBoxCorreo.Text.ToUpper();
            bool agregarParticipante = gestorCompetencia.DarDeAltaParticipante(dtoParticipante, dtocompetencia.CompetenciaId);
            if (!agregarParticipante)
            {
                MessageBox.Show("No se pudo agregar el participante ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_nombre.Text = "";
                textBoxCorreo.Text = "";
            }
            else
            {
                MessageBox.Show("Participante agregado ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_nombre.Text = "";
                textBoxCorreo.Text = "";

            }
        }

   
        private void Cancelar_Click(object sender, EventArgs e)
        {
            Form frmListarParticipante = new ListarParticipante(dtocompetencia, dtoUsuario);
            frmListarParticipante.Show();
            this.Close();

        }

      
    }
}

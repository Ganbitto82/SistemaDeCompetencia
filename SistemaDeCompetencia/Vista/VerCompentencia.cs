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
    public partial class VerCompentencia : Form
    {
        DtoCompetencia dtoCompetencia = new DtoCompetencia();
        DtoUsuario dtoUsuario=new DtoUsuario();
        private GestorCompetencia gComp = new GestorCompetencia();
        
        public VerCompentencia(DtoCompetencia dtocompetencia,DtoUsuario dtoUsuarioForm)
        {
            dtoUsuario = dtoUsuarioForm;

            dtoCompetencia = gComp.VerCompetencia(dtocompetencia.CompetenciaId);
            InitializeComponent();
            textBox_nombre.Text = dtoCompetencia.Nombre;
            textBox_Modalidad.Text = dtoCompetencia.Modalidad.ToString();
            textBox_Deporte.Text = dtoCompetencia.DtoDeporte.Nombre;
            textBox_Estado.Text = dtoCompetencia.Estado.ToString();
            cargarTablaParticipante(dtoCompetencia.Participantes);
            if (dtocompetencia.DtoFixture!=null)

            cargarTablaEncuentro(dtoCompetencia);


        }

        private void cargarTablaParticipante(List<DtoParticipante> listaParticipante)
        {
            
            foreach (var participante in listaParticipante)
            {
                int n = TablaParticipante.Rows.Add();
                TablaParticipante.Rows[n].Cells[0].Value = participante.Nombre;

            }
            TablaParticipante.ClearSelection();
        }

        private void cargarTablaEncuentro(DtoCompetencia dtoCompetencia)
        {

            foreach (var enfrentamiento in dtoCompetencia.DtoFixture.Fechas.First().Enfrentamientos)
            {

                int n = TablaEncuentro.Rows.Add();
                TablaEncuentro.Rows[n].Cells[0].Value = enfrentamiento.ParticipanteX.Nombre;
                TablaEncuentro.Rows[n].Cells[1].Value= "VS" ;
                TablaEncuentro.Rows[n].Cells[2].Value = enfrentamiento.ParticipanteY.Nombre;
            }

        }

   

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Form frmPantallaPrincipal = new PantallaPrincipal(dtoUsuario);
            frmPantallaPrincipal.Show();
            this.Close();
        }

        private void button_participantes_Click(object sender, EventArgs e)
        {
            Form frmListarParticipante = new ListarParticipante(dtoCompetencia,dtoUsuario);
            frmListarParticipante.Show();
            this.Close();
        }

        private void button_generar_Click(object sender, EventArgs e)
        {

            if (gComp.generarFixture(dtoCompetencia.CompetenciaId))
            {
                MessageBox.Show("Fixture generado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Form frmVerCompetencia = new VerCompentencia(dtoCompetencia, dtoUsuario);
                frmVerCompetencia.Show();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Fixture NO generado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
                   
        }
    }
}

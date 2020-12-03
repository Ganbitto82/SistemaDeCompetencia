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
    public partial class ListarParticipante : Form
    {
        private DtoCompetencia dtocomp = new DtoCompetencia();
        private DtoUsuario dtoUsuario = new DtoUsuario();
        private GestorCompetencia gComp = new GestorCompetencia();
        private List<DtoParticipante> listaDtoParticipante = new List<DtoParticipante>();
        public ListarParticipante(DtoCompetencia dtoCompetencia,DtoUsuario dtoUsuarioForm)
        {

            InitializeComponent();
            dtocomp = dtoCompetencia;
            dtoUsuario = dtoUsuarioForm;
            listaDtoParticipante.Clear();
            listaDtoParticipante = gComp.listarParticipantesCompetencia(dtocomp.CompetenciaId);
            cargarTablaParticipante(listaDtoParticipante);
            
        }

   
        private void cargarTablaParticipante(List<DtoParticipante> listadtoParticipante)
        {
            int n;
            foreach (var participante in listadtoParticipante)
            {
                n = tablaDeParticipantes.Rows.Add();
                tablaDeParticipantes.Rows[n].Cells[0].Value = participante.Nombre;
                tablaDeParticipantes.Rows[n].Cells[1].Value = participante.CorreoElectronico;

            }
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {

            if (dtocomp.Estado.ToString().Equals("CREADA") || dtocomp.Estado.ToString().Equals("PLANIFICADA"))
            {
                Form frmDarAltaParticipante = new DarAltaParticipante(dtocomp,dtoUsuario);
                frmDarAltaParticipante.Show();
                this.Close();
            }
            else 
            {
                MessageBox.Show("No se puede agregar participante a la competencia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Form frmVerCompetencia = new VerCompentencia(dtocomp, dtoUsuario);
            frmVerCompetencia.Show();
            this.Close();
        }

        private void salir_Click(object sender, EventArgs e)
        {

        }

        private void button_modificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

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
        private DtoCompetencia dtocompetencia = new DtoCompetencia();
        private DtoUsuario dtoUsuario = new DtoUsuario();
        private GestorCompetencia gComp = new GestorCompetencia();
        private List<DtoParticipante> listaDtoParticipante = new List<DtoParticipante>();
        public ListarParticipante(DtoCompetencia dtoCompetencia,DtoUsuario dtoUsuarioForm)
        {

            InitializeComponent();
            dtocompetencia = dtoCompetencia;
            dtoUsuario = dtoUsuarioForm;
            listaDtoParticipante.Clear();
            listaDtoParticipante = gComp.listarParticipantesCompetencia(dtocompetencia.CompetenciaId);
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

            if (dtocompetencia.Estado.ToString().Equals("CREADA") || dtocompetencia.Estado.ToString().Equals("PLANIFICADA"))
            {
                Form frmDarAltaParticipante = new DarAltaParticipante(dtocompetencia,dtoUsuario);
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
            Form frmVerCompetencia = new VerCompentencia(dtocompetencia, dtoUsuario);
            frmVerCompetencia.Show();
            this.Close();
        }

        private void salir_Click(object sender, EventArgs e)
        {

        }
    }
}

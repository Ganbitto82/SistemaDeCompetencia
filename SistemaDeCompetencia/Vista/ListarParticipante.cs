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
        
        public ListarParticipante(DtoCompetencia dtoCompetencia)
        {
            dtocompetencia = dtoCompetencia;
            InitializeComponent();

            cargarTablaParticipante();
        }

        private void tablaDeParticipantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_ordenacion_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void cargarTablaParticipante() 
        { 
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            Form frmDarAltaParticipante = new  DarAltaParticipante(dtocompetencia);
            frmDarAltaParticipante.Show();
            this.Close();
        }
    }
}

using SistemaDeCompetencia.Dto;
using SistemaDeCompetencia.vista;
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
    public partial class PantallaPrincipal : Form
    {
        DtoUsuario dtoUsuarioForm = new DtoUsuario();
        public PantallaPrincipal(DtoUsuario dtoUsuario)
        {
            dtoUsuarioForm = dtoUsuario;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmInicio = new InicioDeSesion();
            frmInicio.Show();
            this.Close();
        }

        private void button_cu03_Click(object sender, EventArgs e)
        {
            Form frmListarComp = new ListarCompetencia(dtoUsuarioForm);
            frmListarComp.Show();
            this.Close();
        }

        private void button_cu13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no habilitada", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_cu07_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no habilitada", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

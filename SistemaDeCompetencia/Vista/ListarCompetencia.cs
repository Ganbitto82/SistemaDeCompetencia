﻿using SistemaDeCompetencia.Dto;
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
        DtoUsuario dtoUsuarioForm = new DtoUsuario();
        public ListarCompetencia(DtoUsuario dtoUsuario)
        {
            dtoUsuarioForm = dtoUsuario;
            InitializeComponent();
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
    }
}

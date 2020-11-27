﻿using SistemaDeCompetencia.Controladores;
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
        Competencia competencia = new Competencia();

        public VerCompentencia(DtoCompetencia dtocompetencia,DtoUsuario dtoUsuarioForm)
        {
            dtoCompetencia = dtocompetencia;
            dtoUsuario = dtoUsuarioForm;
            InitializeComponent();
            textBox_nombre.Text = dtoCompetencia.Nombre;
            textBox_Modalidad.Text = dtoCompetencia.Modalidad.ToString();
            textBox_Deporte.Text = dtoCompetencia.DtoDeporte.Nombre;
            textBox_Estado.Text = dtoCompetencia.Estado.ToString();

            //gComp.bus;


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void TablaParticipante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_Modalidad_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox_Deporte_TextChanged(object sender, EventArgs e)
        {

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

          //  competencia = gComp.b;
        }
    }
}

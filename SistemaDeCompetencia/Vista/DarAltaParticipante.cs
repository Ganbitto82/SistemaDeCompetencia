﻿using SistemaDeCompetencia.Controladores;
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
        int flag = 0;

        private GestorCompetencia gestorCompetencia= new GestorCompetencia();
        public DarAltaParticipante(DtoCompetencia dtoCompetencia,DtoUsuario dtoUsuarioForm)
        {
            dtoUsuario = dtoUsuarioForm;
            dtocompetencia = dtoCompetencia;
            InitializeComponent();
        }

       

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (textBox_nombre.Text.Equals("") || textBoxCorreo.Text.Equals("")) 
            {
                MessageBox.Show(" Los campos nombre y correo no pueden estar vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                DtoParticipante dtoParticipante = new DtoParticipante();
                dtoParticipante.Nombre = textBox_nombre.Text.ToUpper();
                dtoParticipante.CorreoElectronico = textBoxCorreo.Text.ToUpper();

                bool agregarParticipante = gestorCompetencia.DarDeAltaParticipante(dtoParticipante, dtocompetencia.CompetenciaId);
                if (!agregarParticipante)
                {
                    MessageBox.Show("No se pudo agregar el participante ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_nombre.Text = "";
                    textBoxCorreo.Text = "";
                }
                else
                {

                    //bandera solo para mostrar por unica vez que se elimino el fixture
                    if (flag == 0)
                    {
                        if (dtocompetencia.Estado.ToString().Equals("PLANIFICADA"))
                        {
                            MessageBox.Show("Se elimino el fixture ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                    flag = 1;
                    MessageBox.Show("Participante agregado ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox_nombre.Text = "";
                    textBoxCorreo.Text = "";

                }
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

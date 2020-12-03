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
        DtoCompetencia dtoComp = new DtoCompetencia();
        DtoUsuario dtoUsuario=new DtoUsuario();
        private GestorCompetencia gComp = new GestorCompetencia();
        
        public VerCompentencia(DtoCompetencia dtocompetencia,DtoUsuario dtoUsuarioForm)
        {
            dtoUsuario = dtoUsuarioForm;

            dtoComp = gComp.VerCompetencia(dtocompetencia.CompetenciaId);
            InitializeComponent();
            textBox_nombre.Text = dtoComp.Nombre;
            textBox_Modalidad.Text = dtoComp.Modalidad.ToString();
            textBox_Deporte.Text = dtoComp.DtoDeporte.Nombre;
            textBox_Estado.Text = dtoComp.Estado.ToString();
            cargarTablaParticipante(dtoComp.Participantes);
            if (dtoComp.DtoFixture!=null)

            cargarTablaEncuentro(dtoComp);


        }

        private void cargarTablaParticipante(List<DtoParticipante> listaParticipante)
        {
            TablaParticipante.ClearSelection();
            foreach (var participante in listaParticipante)
            {
                int n = TablaParticipante.Rows.Add();
                TablaParticipante.Rows[n].Cells[0].Value = participante.Nombre;

            }
            
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
            Form frmListarComp = new ListarCompetencia(dtoUsuario);
            frmListarComp.Show();
            this.Close();
        }

        private void button_participantes_Click(object sender, EventArgs e)
        {
            Form frmListarParticipante = new ListarParticipante(dtoComp,dtoUsuario);
            frmListarParticipante.Show();
            this.Close();
        }

        private void button_generar_Click(object sender, EventArgs e)
        {
            try


            {
                if (!dtoComp.Modalidad.Equals("SISTEMA_DE_LIGA")) 
                {
                    throw new Exception("SOLO SE PUEDE GENERAR FIXTURE PARA SISTEMA DE LIGA");
                
                }
                if (dtoComp.Estado.Equals(Estado.ENDISPUTA) || dtoComp.Estado.Equals(Estado.FINALIZADA))
                {

                    throw new Exception("No se puede generar un fixture");
                  
                    
                }

                if (gComp.generarFixture(dtoComp.CompetenciaId))
                {
                    MessageBox.Show("Fixture generado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Form frmVerCompetencia = new VerCompentencia(dtoComp, dtoUsuario);
                    frmVerCompetencia.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fixture NO generado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message , "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
           
            
                   
        }

        private void button_modificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button_DarDeBaja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button_fixture_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button_tablaPosicion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    }
    


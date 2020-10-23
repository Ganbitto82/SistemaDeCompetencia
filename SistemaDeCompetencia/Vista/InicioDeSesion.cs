using SistemaDeCompetencia.Controladores;
using SistemaDeCompetencia.Dao;
using SistemaDeCompetencia.Dto;
using SistemaDeCompetencia.Modelo;
using SistemaDeCompetencia.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeCompetencia.vista

{
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            //DAOCompetenciaEntityFramework dao = new DAOCompetenciaEntityFramework();
            //dao.buscarCompetencias("", "", "", "FUTBOL");
            InitializeComponent();
        }

        private void Form_InicioDeSesion_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {


        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
           // DAOCompetenciaEntityFramework dao = new DAOCompetenciaEntityFramework();
            //dao.buscarCompetencias("a", "", "SISTEMA_DE_LIGA", "");
            DtoLogin dtoLog = new DtoLogin();
            dtoLog.correoElectronico = textBoxCorreo.Text.ToUpper();
            dtoLog.Contraseña = textBoxContraseña.Text.ToUpper();

            if (!(dtoLog.correoElectronico.Equals("") && dtoLog.Contraseña.Equals("")))
            {

                GestorUsuario gest = new GestorUsuario();
                try
                {
                    DtoUsuario user = gest.autenticarUsusario(dtoLog);
                    Form frm2 = new PantallaPrincipal(user);
                    frm2.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, "Datos Invalidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxCorreo.Clear();
                    textBoxContraseña.Clear();

                }




            }
            else MessageBox.Show("Complete todos los datos.", "Datos Invalidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            

        }
    }

       
    
}

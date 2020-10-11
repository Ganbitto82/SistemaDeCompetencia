﻿using SistemaDeCompetencia.Dto;
using SistemaDeCompetencia.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeCompetencia
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            int idDtoUsusario = 1;
            Application.Run(new DarAltaCompetencia(new DtoUsuario(idDtoUsusario)));
        }
    }
}

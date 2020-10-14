﻿using SistemaDeCompetencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCompetencia.Dao
{
    interface DAODeporte
    {
        List<Deporte> listarDeportes(int idUsuario);
        List<Deporte> listarDeportes();
        Deporte buscarPorId(int idDeporte);
    }
}

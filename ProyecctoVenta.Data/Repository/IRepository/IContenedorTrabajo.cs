﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta.Data.Repository.IRepository
{
    public interface IContenedorTrabajo : IDisposable
    {
        //IOficinaRepository Oficina { get; }
        //IUsuarioRepository Usuario { get; }
        //ISliderRepository Slider { get; }
        void Save();
    }
}

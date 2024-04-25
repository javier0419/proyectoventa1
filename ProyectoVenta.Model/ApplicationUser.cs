﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string NombreUsuario { get; set; }
        public string Carrera { get; set; }

    }
}
    
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public enum TipoUsuario
    {
        NORMAL = 1,
        ADMIN = 2,
    }
    public class Usuario
    {

        public int Id { get; set; }

        public string User { get; set; }

        public string Pass { get; set; }

        public TipoUsuario TipoUsuario { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Mail { get; set; }

        public string ImagenPerfil { get; set; }

        public Usuario(string user, string pass, bool admin)
        {
            User = user;
            Pass = pass;
            TipoUsuario = admin ? TipoUsuario.ADMIN : TipoUsuario.NORMAL;
        }

        public Usuario() { }

    }
}


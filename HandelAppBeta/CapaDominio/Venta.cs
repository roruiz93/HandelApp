﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class Venta
    {
        public int IDVenta { get; set; }
        public List<Producto> ProductoVenta { get; set; }
        public Cliente ClienteVenta { get; set; }
        public Usuario UsuarioVenta { get; set; }
        public decimal TotalVenta { get; set; }
        public DateTime DiaVenta { get; set; }
    }
}

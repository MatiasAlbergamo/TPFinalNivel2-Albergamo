﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int CodigoDeArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; } 
        public Categoria Categoria { get; set; } 
        public string Imagen { get; set; }
        public int Precio { get; set; }
    }
}

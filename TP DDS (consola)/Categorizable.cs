﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TP_DDS__consola_
{
    class Categorizable
    {
        private List<Categoria> categorias;

        public List<Categoria> getCategorias() { return categorias; }

        public void addCategoria(Categoria cat) { this.categorias.Add(cat); }
    }
}

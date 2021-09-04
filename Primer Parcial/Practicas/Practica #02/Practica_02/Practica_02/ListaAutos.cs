using System;
using System.Collections.Generic;


namespace Practica_02
{
    class ListaAutos : List<Auto>
    {
        private static ListaAutos instancia = null;

        private ListaAutos() { }

        public static ListaAutos ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new ListaAutos();
            return instancia;
        }
    }
}

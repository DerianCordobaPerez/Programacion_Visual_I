using System;
using System.Collections.Generic;


namespace Practica_02
{
    class ListaAutos : List<Auto>
    {
        private static ListaAutos _instancia = null;

        private ListaAutos() { }

        public static ListaAutos ObtenerInstancia()
        {
            if (_instancia == null)
                _instancia = new ListaAutos();
            return _instancia;
        }
    }
}

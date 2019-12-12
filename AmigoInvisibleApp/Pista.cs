using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmigoInvisibleApp
{
    public class Pista
    {
        DateTime fecha;
        string texto;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }

        public Pista(DateTime pFecha, string pTexto)
        {
            Fecha = pFecha;
            Texto = pTexto;
        }

        public override string ToString()
        {
            return Fecha +" "+ Texto;
        }
    }
}
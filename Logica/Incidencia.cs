using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    //Punto 12: Alternativa punto 8
    public interface IDescripcionIncidencia
    {
        //string ObtenerDescripcionIncidencia();
    }

    //Punto 8
    public abstract class Incidencia
    {
        public short MinutoDeJuego { get; set; }      
        
        public abstract string ObtenerDescripcionIncidencia();
    }
}

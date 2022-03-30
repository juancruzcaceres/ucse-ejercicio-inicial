using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class TorneoDeFutbol
    {
        public List<Partido> Partidos { get; set; }

        //Punto 6
        public bool NuevoPartido(Arbitro arbitro, string ciudad, Equipo equipoLocal, Equipo equipoVisitante)
        {
            List<Arbitro> arbitros = new List<Arbitro>();
            arbitro.PartidosJugados++;

            arbitros.Add(arbitro);

            Partido nuevoPartido = new Partido()
            {
                Arbitros = arbitros,
                EquipoLocal = equipoLocal,
                EquipoVisitante = equipoVisitante
            };

            nuevoPartido.GuardarCiudad(ciudad);

            this.Partidos.Add(nuevoPartido);

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiApp.Eventos
{
    public class Evento
    {
        public Evento(int ID, DateTime fecha, string equipoLocal, string equipoVisitante)
        {
            this.EventoId = ID;
            this.Fecha = fecha;
            this.EquipoLocal = equipoLocal;
            this.EquipoVisitante = equipoVisitante;
        }

        public int EventoId { get; set; }
        public DateTime Fecha { get; set; }
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }

        public Evento(Evento p)
        {
            EventoId = p.EventoId;
            Fecha = p.Fecha;
            EquipoLocal = p.EquipoLocal;
            EquipoVisitante = p.EquipoVisitante;
        }

        public Evento()
        {
        }
    }
}

using MiApp.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiApp.Mercados
{
    public class Mercado
    {
        public Mercado(int ID, double tipo, double cuotaOver, double cuotaUnder, double apostadoOver, double apostadoUnder, int ID_eventos)
        {
            this.MercadoId = ID;
            this.Tipo = tipo;
            this.CuotaOver = cuotaOver;
            this.CuotaUnder = cuotaUnder;
            this.ApostadoOver = apostadoOver;
            this.ApostadoUnder = apostadoUnder;
            this.EventoId = ID_eventos;
        }

        public int MercadoId { get; set; }
        public double Tipo { get; set; }
        public double CuotaOver { get; set; }
        public double CuotaUnder { get; set; }
        public double ApostadoOver { get; set; }
        public double ApostadoUnder { get; set; }
        public int EventoId { get; set; }
        public Evento Evento { get; set; }


        public Mercado(Mercado p)
        {
            MercadoId = p.MercadoId;
            Tipo = p.Tipo;
            CuotaOver = p.CuotaOver;
            CuotaUnder = p.CuotaUnder;
            ApostadoOver = p.ApostadoOver;
            ApostadoUnder = p.ApostadoUnder;
            EventoId = p.EventoId;

        }

        public Mercado()
        {
        }
    }
}

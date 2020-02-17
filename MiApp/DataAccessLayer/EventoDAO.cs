using MiApp.Eventos;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiApp.DataAccessLayer
{
    class EventoDAO
    {
        public static ICollection<Evento> GetAllEvento()
        {
            ICollection<Evento> eventos = new List<Evento>();
            using (var context = new DataBaseContext())
            {
                eventos = context.Eventos.ToList();
            }
            return eventos;
        }

        public static Evento GetByIDEvento(int ID) //buscamos x ID
        {

            Evento c = new Evento();
            using (var context = new DataBaseContext())
            {
                c = context.Eventos.Where(e => e.EventoId == ID).FirstOrDefault();
            }

            return c;

        }

        public static bool updateEventos(Evento c)
        {
            Evento e = new Evento();
            try{
                using (var context = new DataBaseContext())
                {
                    e = context.Eventos.Where(b => b.EventoId == c.EventoId).FirstOrDefault();
                    e = c;

                    context.SaveChanges();
                }
                return true;
            }catch{
                return false;
            }
            
        }

        public static bool InsertEventos(Evento c) //introduce un nuevo objeto de tipo eventos en la base de datos
        {
            try
            {
                var context = new DataBaseContext();
                context.Eventos.Add(c);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteEventos(Evento c) // borramos un evento pasado x campo
        {
            try
            {
                using (var context = new DataBaseContext())
                {
                    context.Remove(c);
                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static int InsertEventosSinID(DateTime fecha,string equipoLocal,string equipoVisitante) //introduce un nuevo objeto de tipo eventos en la base de datos
        {
            int IDEventos = 0;

            using (var context = new DataBaseContext())
            {
                context.Eventos.ForEachAsync(b =>
                {
                    if(b.EventoId > IDEventos)
                    {
                        IDEventos = b.EventoId;
                    }
                });

                Evento e = new Evento(IDEventos + 1, fecha, equipoLocal, equipoVisitante);

                context.Add(e);
            }

            return IDEventos;
        }

        


    }
}

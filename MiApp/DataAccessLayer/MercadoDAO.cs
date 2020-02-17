using MiApp.Mercados;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiApp.DataAccessLayer
{
    class MercadoDAO
    {

        public static ICollection<Mercado> GetAllMercado()
        {
            ICollection<Mercado> mercados = new List<Mercado>();
            using (var context = new DataBaseContext())
            {
                mercados = context.Mercados.ToList();
            }
            return mercados;
        }

        public static Mercado GetByIDMercado(int ID) //buscamos x ID
        {
            Mercado c = new Mercado();
            using (var context = new DataBaseContext())
            {
                c = context.Mercados.Where(e => e.MercadoId == ID).FirstOrDefault();
            }

            return c;
        }

        public static bool updateMercados(Mercado c)
        {
            Mercado e = new Mercado();
            try
            {
                using (var context = new DataBaseContext())
                {
                    e = context.Mercados.Where(b => b.MercadoId == c.MercadoId).FirstOrDefault();
                    e = c;

                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool InsertMercados(Mercado c) //introduce un nuevo objeto de tipo mercados en la base de datos
        {
            try
            {
                var context = new DataBaseContext();
                context.Mercados.Add(c);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteMercados(Mercado c) // borramos un mercado pasado x campo
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

        public static bool InsertMercadosSinID(double tipo, double cuotaOver, double cuotaUnder, double apostadoOver, double apostadoUnder, int ID_eventos) //introduce un nuevo objeto de tipo mercados en la base de datos
        {
            int IDMercados = 0;
            try
            {
                using (var context = new DataBaseContext())
                {
                    context.Mercados.ForEachAsync(b =>
                    {
                        if (b.MercadoId > IDMercados)
                        {
                            IDMercados = b.MercadoId;
                        }
                    });

                    Mercado e = new Mercado(IDMercados + 1,tipo, cuotaOver, cuotaUnder, apostadoOver, apostadoUnder, ID_eventos);

                    context.Add(e);
                }

                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}

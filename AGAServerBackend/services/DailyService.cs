using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AGAServerBackend.Models;
using AGAServerBackend.Context;

namespace AGAServerBackend.services
{
    public class DailyService : IDailyPart
    {
        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<DailyPart> findAllDailyParts()
        {
            var dailyParts = new List<DailyPart>();

            return null;
        }

        public DailyPart findById(int id)
        {
            throw new NotImplementedException();
        }

        public void save(DailyPart dailyPart)
        {
            using (var context = new ApplicationDataContext())
            {
                try
                {
                    //context.DailyParts.Add(dailyPart);
                    //context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("No se puede guardar el registro", ex);
                }
            }
        }

        public void update(DailyPart dailyPart)
        {
            using (var context = new ApplicationDataContext())
            {
                try
                {
                    //context.Entry(DailyPart).State = EntityState.Modified;
                    //context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("No se puede actualizar el registro", ex);
                }
            }
        }
    }
}
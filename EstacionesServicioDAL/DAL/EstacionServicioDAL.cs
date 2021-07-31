using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionesServicioDAL.DAL
{
    public class EstacionServicioDAL
    {
        public EstacionesServicioBDEntities dbEntities = new EstacionesServicioBDEntities();

        public void Add(EstacionServicio es)
        {
            dbEntities.EstacionServicio.Add(es);
            dbEntities.SaveChanges();
        }

        public List<EstacionServicio> GetAll()
        {
            return dbEntities.EstacionServicio.ToList();
        }

        public void Remove(int idEstacion)
        {
            EstacionServicio es = dbEntities.EstacionServicio.Find(idEstacion);
            dbEntities.EstacionServicio.Remove(es);
            dbEntities.SaveChanges();
        }

        public EstacionServicio buscarEstacion(int idEstacion)
        {
            return dbEntities.EstacionServicio.Find(idEstacion);
        }

        



    }
}

using ProyectoVenta.Data.Repository.IRepository;
using ProyectoVenta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta.Data.Repository
{
    /*public class OficinaRepository : Repository<Oficina>, IOficinaRepository
    {
        private readonly ApplicationDbContext _db;
        public OficinaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Oficina oficina)
        {
            var objDesdeDb = _db.Oficina.FirstOrDefault(s => s.Id == oficina.Id);
            objDesdeDb.NombreOficina = oficina.NombreOficina;
            objDesdeDb.Direccion = oficina.Direccion;
        }

    }*/
}

using Farmacia.Abstactions;
using Farmacia.DataAccess;
using Farmacia.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Farmacia.DataAccess
{
    public class DbContext<T> : IDbContext<T> where T : class, IEntidad
    {
        DbSet<T> _Items;
        DbDataAccess _ctx;
        public DbContext(DbDataAccess ctx)
        {
            _ctx = ctx;
            _Items = _ctx.Set<T>();
        }

        // Consulta base. Para Medicamento se incluye la Marca para que NombreMarca llegue a la API
        private IQueryable<T> Consulta()
        {
            if (typeof(T) == typeof(Medicamento))
            {
                return (IQueryable<T>)(object)_ctx.Medicamentos.Include(m => m.Marca);
            }
            return _Items;
        }

        public void Delete(int id)
        {
            var entity = _Items.FirstOrDefault(i => i.Id == id);
            if (entity != null) { _Items.Remove(entity); }
            _ctx.SaveChanges();
        }

        public IList<T> GetAll()
        {
            return Consulta().ToList();
        }

        public T GetById(int id)
        {
            return Consulta().FirstOrDefault(i => i.Id == id);
        }

        public T Save(T entity)
        {
            if (entity.Id.Equals(0))
            {
                _Items.Add(entity);
            }
            else
            {
                //var entityDb = GetById(entity.Id);
                //_ctx.Entry(entityDb).State = EntityState.Modified;
                _Items.Update(entity);
            }
            _ctx.SaveChanges();
            return entity;
        }
    }
}

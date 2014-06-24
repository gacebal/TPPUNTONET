using dominio.Models;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Repositorios
{
    public abstract class RepositorioBase<T> : IRepositorioBase<T> where T : class
    {
        private BaseTPContext _context;

        protected virtual BaseTPContext BaseTPContext
        {
            get
            {
                if (_context == null)
                {
                    _context = new BaseTPContext();
                }
                return _context;
            }
        }

        public int Crear(T entity)
        {
            BaseTPContext.Set<T>().Add(entity);
            return BaseTPContext.SaveChanges();
        }

        public int Actualizar(T entity)
        {
            BaseTPContext.Entry(entity).State = EntityState.Modified;
            return BaseTPContext.SaveChanges();
        }

        public int Borrar(T entity)
        {
            BaseTPContext.Entry(entity).State = EntityState.Deleted;
            return BaseTPContext.SaveChanges();
        }

        public List<T> Listar()
        {
            return BaseTPContext.Set<T>().ToList<T>();
        }

        public void Liberar()
        {
            if (_context != null)
            {
                _context.Dispose();
                _context = null;
            }
        }
    }
}

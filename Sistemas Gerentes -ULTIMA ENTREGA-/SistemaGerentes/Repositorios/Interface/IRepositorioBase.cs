using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repositorio
{
    interface IRepositorioBase<T> where T : class
    {
        List<T> Listar();
        int Crear(T entity);
        int Actualizar(T entity);
        int Borrar(T entity);
    }
}

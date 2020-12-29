using inventario.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.Interfaces
{
    public interface IRepositorio<T> where T:Base
    {
        bool Create(T Entidad);
        bool Update(T EntidadModificada);
        bool Delete(string id);
        List<T> read { get;}
    }
}

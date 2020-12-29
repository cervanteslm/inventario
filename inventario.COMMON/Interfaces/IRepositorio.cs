using inventario.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.Interfaces
{
    public interface IRepositorio<T> where T:Base
    {
        bool Crear { get; }
        bool Editar(string id, T EntidadModificada);
        bool Eliminar(T entidad);
        List<T> Leer { get;}
    }
}

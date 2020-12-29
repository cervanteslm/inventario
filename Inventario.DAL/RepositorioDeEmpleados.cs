using inventario.COMMON.Entidades;
using inventario.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.DAL
{
    public class RepositorioDeEmpleados : IRepositorio<Empleado>
    {
        public List<Empleado> Leer => throw new NotImplementedException();

        public bool Crear(Empleado entidad)
        {
            throw new NotImplementedException();
        }

        public bool Editar(Empleado entidadOriginal, Empleado EntidadModificada)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Empleado entidad)
        {
            throw new NotImplementedException();
        }
    }
}

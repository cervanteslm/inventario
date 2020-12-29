using inventario.COMMON.Entidades;
using inventario.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.DAL
{
    public class RepositorioDeEmpleados : IRepositorio<Empleado>
    {
        private string DBName = "Inventario.db";
        private string TableName = "Empleados";
        public List<Empleado> Read {
            get
            {
                List<Empleado> datos = new List<Empleado>();
                using (var db = new LiteDataBase(DBName))
                {
                    datos = db.GetCollection<Empleado>(TableName).FindAll().Tolist();
                }
                return datos;
            }
        }

        public bool Create(Empleado entidad)
        {
            entidad.Id = Guid.NewGuid().ToString();
            try
            {
                using (var db = new LiteDataBase(DBName))
                {
                    var coleccion = db.GetCollection<Empleado>(TableName);
                    coleccion.Insert(entidad);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

        public bool Update(Empleado EntidadModificada)
        {
            try
            {
                using (var db = new LiteDataBase(DBName))
                {
                    var coleccion = db.GetCollection<Empleado>(TableName);
                    coleccion.Update(EntidadModificada);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(string id)
        {
            try
            {
                int r;
                using (var db = new LiteDataBase(DBName))
                {
                    var coleccion = db.GetCollection<Empleado>(TableName);
                    r = coleccion.Delete(e => e.Id == id);
                }

                return r > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

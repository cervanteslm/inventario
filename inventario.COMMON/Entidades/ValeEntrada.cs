using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.Entidades
{
    public class ValeEntrada:Base
    {
        public DateTime Fecha { get; set; }
        public List<Material> Materiales { get; set; }
        public Empleado EncargadoDeAlmacen { get; set; }
        public List<Distrito> Distrito { get; set; }
    }
}

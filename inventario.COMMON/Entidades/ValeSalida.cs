using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.COMMON.Entidades
{
    class ValeSalida:Base
    {
        public DateTime FechaEntrega { get; set; }
        public List<Material> Materiales { get; set; }
        public Empleado solicitante { get; set; }
        public Empleado EncargadoDeAlmacen { get; set; }
        public List <Distrito> Distrito { get; set; }

    }
}

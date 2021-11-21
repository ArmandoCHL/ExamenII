using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OrdenEntity
    {
        public OrdenEntity()
        {
            Producto = Producto ?? new ProductoEntity();
        }

        public int? IdOrden { get; set; }

        public virtual ProductoEntity Producto { get; set; }
        public int? CantidadProducto { get; set; }
        public string Estado { get; set; }
    }
}
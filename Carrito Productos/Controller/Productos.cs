using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carrito_Productos
{
    public class Productos
    {
        public Productos(string nombre, int cantidad, decimal costo, byte imagen)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Costo = costo;
            Imagen = imagen;
        }

        public Productos() { }

        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }
        public byte Imagen { get; set; }
    }
}
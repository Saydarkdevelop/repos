//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Doña_Juanita.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pedidos
    {
        public int Id { get; set; }
        public string NombreP { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public Nullable<int> Descuento { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Productos Productos { get; set; }
        public virtual Productos Productos1 { get; set; }
        public virtual TipoCliente TipoCliente { get; set; }
    }
}

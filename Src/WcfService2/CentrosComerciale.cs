//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService2
{
    using System;
    using System.Collections.Generic;
    
    public partial class CentrosComerciale
    {
        public int idCentro { get; set; }
        public string nombreCentro { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
        public Nullable<int> tiendas { get; set; }
        public string cine { get; set; }
        public string url { get; set; }
        public Nullable<double> latitud { get; set; }
        public Nullable<double> longitud { get; set; }
    }
}

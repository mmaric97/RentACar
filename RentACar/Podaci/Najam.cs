//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Podaci
{
    using System;
    using System.Collections.Generic;
    
    public partial class Najam
    {
        public int id_najam { get; set; }
        public int id_automobil { get; set; }
        public int id_korisnik { get; set; }
        public System.DateTime datum_najma { get; set; }
        public System.DateTime datum_povrata { get; set; }
        public string nastala_steta { get; set; }
        public Nullable<bool> zavrsen { get; set; }
        public Nullable<decimal> iznos_štete { get; set; }
    
        public virtual Automobil Automobil { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}

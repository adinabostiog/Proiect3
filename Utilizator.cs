//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiCuAstaPasta.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Utilizator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Utilizator()
        {
            this.Comandas = new HashSet<Comanda>();
        }
    
        public int id { get; set; }
        public string prenume { get; set; }
        public string nume { get; set; }
        public string email { get; set; }
        public string parola { get; set; }
        public string telefon { get; set; }
        public string adresa { get; set; }
        public bool angajat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comanda> Comandas { get; set; }
    }
}

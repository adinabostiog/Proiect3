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
    
    public partial class Comanda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comanda()
        {
            this.ComandaMenius = new HashSet<ComandaMeniu>();
            this.ComandaPreparats = new HashSet<ComandaPreparat>();
        }
    
        public int id { get; set; }
        public int fk_utilizator { get; set; }
        public string stare { get; set; }
        public System.DateTime timp_inregistrare { get; set; }
        public double discount { get; set; }
        public double cost_transport { get; set; }
        public double pret_total { get; set; }
        public System.DateTime ora_estimativa_livrare { get; set; }
    
        public virtual Utilizator Utilizator { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComandaMeniu> ComandaMenius { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComandaPreparat> ComandaPreparats { get; set; }
    }
}

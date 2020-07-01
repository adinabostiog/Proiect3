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
    
    public partial class Preparat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Preparat()
        {
            this.ComandaPreparats = new HashSet<ComandaPreparat>();
            this.MeniuPreparats = new HashSet<MeniuPreparat>();
            this.PreparatAlergenis = new HashSet<PreparatAlergeni>();
        }
    
        public int id { get; set; }
        public string nume { get; set; }
        public double pret { get; set; }
        public string unitate_masura { get; set; }
        public double cantitate_per_portie { get; set; }
        public double cantitate_totala { get; set; }
        public int fk_categorie { get; set; }
    
        public virtual Categorie Categorie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComandaPreparat> ComandaPreparats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MeniuPreparat> MeniuPreparats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PreparatAlergeni> PreparatAlergenis { get; set; }
    }
}

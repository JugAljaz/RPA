//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VajaBazeIndividualno.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mentor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mentor()
        {
            this.IzvedbaMentor = new HashSet<IzvedbaMentor>();
            this.PlanSodelavci = new HashSet<PlanSodelavci>();
        }
    
        public int MenId { get; set; }
        public string MenIme { get; set; }
        public string MenPriimek { get; set; }
        public byte[] MenSlika { get; set; }
        public string MenVloga { get; set; }
        public string MenNaziv { get; set; }
        public string MenUstanova { get; set; }
        public Nullable<System.Guid> UserID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IzvedbaMentor> IzvedbaMentor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanSodelavci> PlanSodelavci { get; set; }
    }
}

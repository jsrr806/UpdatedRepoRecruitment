//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary_Recruitment
{
    using System;
    using System.Collections.Generic;
    
    public partial class BusinessUnitTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BusinessUnitTable()
        {
            this.BusinessUnitReqTables = new HashSet<BusinessUnitReqTable>();
        }
    
        public int BId { get; set; }
        public string BName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessUnitReqTable> BusinessUnitReqTables { get; set; }
    }
}

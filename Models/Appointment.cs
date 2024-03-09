//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IBMCAS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Appointment()
        {
            this.Advices = new HashSet<Advice>();
        }
    
        public int AppointmentID { get; set; }
        public string AppointmentToken { get; set; }
        public int PatientID { get; set; }
        public int PhysicianID { get; set; }
        public System.DateTime ScheduledDate { get; set; }
        public int ScheduledTime { get; set; }
        public string Advice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Advice> Advices { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Physician Physician { get; set; }
    }
}
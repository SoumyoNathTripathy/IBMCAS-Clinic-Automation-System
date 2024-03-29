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
    using System.ComponentModel.DataAnnotations;

    public partial class PatientRegistrationQueue
    {
        public int PRQID { get; set; }
        public string RegistrationTokenNo { get; set; }
        public System.DateTime DateCreated { get; set; }
        [Required]
        public System.DateTime PatientDOB { get; set; }
        [Required]
        public string PatientFirstName { get; set; }
        [Required]
        public string PatientLastName { get; set; }
        [Required]
        public string PatientAddress { get; set; }
        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public string PatientPhone { get; set; }
        [Required]
        [EmailValidation]
        public string PatientEmail { get; set; }
        [Required]
        public string PatientGender { get; set; }
        public string PatientMedicalHistory { get; set; }
        [Required]
        [MaxLength(12)]
        [MinLength(12)]
        public string PatientAadhaarNumber { get; set; }
    }
}

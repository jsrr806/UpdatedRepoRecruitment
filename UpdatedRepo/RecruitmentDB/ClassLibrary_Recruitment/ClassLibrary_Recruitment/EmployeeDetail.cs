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
    
    public partial class EmployeeDetail
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int BId { get; set; }
        public string Designation { get; set; }
        public bool Status { get; set; }
        public int JobExperience { get; set; }
    
        public virtual EmployeeDetail EmployeeDetails1 { get; set; }
        public virtual EmployeeDetail EmployeeDetail1 { get; set; }
    }
}

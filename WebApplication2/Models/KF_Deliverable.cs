//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KF_Deliverable
    {
        public int deliverableID { get; set; }
        public string Kaizen_ID { get; set; }
        public string deliverable { get; set; }
    
        public virtual KF_Main KF_Main { get; set; }
    }
}

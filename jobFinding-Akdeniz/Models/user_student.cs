//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jobFinding_Akdeniz.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user_student
    {
        public int userAccountID { get; set; }
        public Nullable<int> intrestedSectorId { get; set; }
        public string statusStd { get; set; }
    
        public virtual business_stream business_stream { get; set; }
        public virtual user_account user_account { get; set; }
    }
}

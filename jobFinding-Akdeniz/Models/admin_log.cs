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
    
    public partial class admin_log
    {
        public int adminAccountID { get; set; }
        public System.DateTime loginDate { get; set; }
        public string loginIp { get; set; }
    
        public virtual user_admin user_admin { get; set; }
    }
}

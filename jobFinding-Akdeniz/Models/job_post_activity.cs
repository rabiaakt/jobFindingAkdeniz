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
    
    public partial class job_post_activity
    {
        public int activityId { get; set; }
        public int userAccountID { get; set; }
        public int jobPostID { get; set; }
        public System.DateTime applyDate { get; set; }
    
        public virtual job_post job_post { get; set; }
        public virtual user_account user_account { get; set; }
    }
}

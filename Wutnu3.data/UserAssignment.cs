//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wutnu.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserAssignment
    {
        public long UserAssignmentId { get; set; }
        public int WutLinkId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string UserEmail { get; set; }
    
        public virtual User User { get; set; }
        public virtual WutLink WutLink { get; set; }
    }
}

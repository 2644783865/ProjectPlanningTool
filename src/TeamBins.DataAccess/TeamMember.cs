//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeamBins.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeamMember
    {
        public int ID { get; set; }
        public int MemberID { get; set; }
        public int TeamID { get; set; }
        public Nullable<int> DefaultProjectID { get; set; }
        public int CreatedByID { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual Team Team { get; set; }
        public virtual User User { get; set; }
        public virtual User Member { get; set; }
    }
}

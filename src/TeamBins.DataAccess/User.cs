//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartPlan.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Tasks = new HashSet<Task>();
            this.Issues = new HashSet<Issue>();
            this.Issues1 = new HashSet<Issue>();
            this.ProjectMembers = new HashSet<ProjectMember>();
            this.Projects = new HashSet<Project>();
            this.Comments = new HashSet<Comment>();
        }
    
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string JobTitle { get; set; }
        public Nullable<int> DefaultProjectID { get; set; }
    
        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
        public virtual ICollection<Issue> Issues1 { get; set; }
        public virtual ICollection<ProjectMember> ProjectMembers { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Project DefaultProject { get; set; }
    }
}

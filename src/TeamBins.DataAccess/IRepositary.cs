﻿
using SmartPlan.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Planner.DataAccess
{
    public interface IRepositary : IDisposable  
    {
        bool DeleteProject(int projectId);
      //  Document GetDocument(string documentKey);
     //   List<Document> GetDocuments(int parentId, string type);
       // List<Bug> GetBugs(int page, int size);
        IEnumerable<Project> GetProjects();
        Project GetProject(int projectId);
        Project GetProject(int projectId, int createdById);
        Project GetProject(string name, int createdById);
        List<Priority> GetPriorities();
        List<Status> GetStatuses();
        List<Category> GetCategories();
     ////   OperationStatus SaveBug(Bug bug);
        OperationStatus SaveIssue(Issue bug);
       // OperationStatus SaveDocument(Document image);
        Project SaveProject(Project project);
        OperationStatus SaveProjectMember(ProjectMember projectMember);
       // Bug GetBug(int id);

        OperationStatus SaveUser(User user);
        User GetUser(string emailAddress);

        IEnumerable<Team> GetTeams(int userId);
        Team GetTeam(int teamId);
        Team SaveTeam(Team team);
        //TeamMemberRequest AddTeamMemberRequest(TeamMemberRequest request);
      //  TeamMember SaveTeamMember(TeamMember teamMember);
        IEnumerable<Issue> GetIssues();
        Issue GetIssue(int issueId);
        IEnumerable<Comment> GetCommentsForIssue(int issueId);
        OperationStatus SaveComment(Comment comment);
        Comment GetComment(int commentId);
/* 
        List<User> GetTeamMembers(int teamId);
        List<User> GetIssueMembers(int issueId);
        List<User> GetNonIssueMembers(int teamId, int issueId);
        OperationStatus SaveIssueMember(int issueId, int memberId, int addedBy);
        OperationStatus DeleteIssueMember(int issueId, int memberId);
        
 * /
 * 

 /* 
       

        IEnumerable<Activity> GetTeamActivity(int teamId);
        OperationStatus SaveActivity(Activity comment);*/

    }
}

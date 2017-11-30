using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectManagementSoftware.DAL;
using ProjectManagementSoftware.Models;

namespace ProjectManagementSoftware.BLL
{
    public class ProjectManager
    {
        ProjectGateway projectGateway = new ProjectGateway();

        public int Save(Project project)
        {
            return projectGateway.Save(project);
        }

        public List<Project> ListofProjects()
        {
            return projectGateway.ListofpProjects();
        }

        public bool AssignPerson(AssignViewModel assignView)
        {
            return projectGateway.AssignProjectAndPerson(assignView);
        }
    }
}
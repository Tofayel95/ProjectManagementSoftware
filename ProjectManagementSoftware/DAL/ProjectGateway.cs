using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ProjectManagementSoftware.Models;

namespace ProjectManagementSoftware.DAL
{
    public class ProjectGateway : ConnectionGateway
    {

        public int Save(Project project)
        {
            Connection.Open();

            string query = "Insert into Project values('"+ project.Name+"','"+project.Code +"','"+project.Description +"','"+project.StartDate +"','"+ project.EndDate+"','"+project.Duration +"','"+project.Status +"','Not Assigned Yet')";

            Command.CommandText = query;
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;

        }

        public List<Project> ListofpProjects()
        {
            Connection.Open();
            string query = "select * from Project";

            Command.CommandText = query;
            List<Project> projects = new List<Project>();

            SqlDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Project project = new Project();
                    project.Id = (int) reader["Id"];
                    project.Name = reader["Name"].ToString();
                    projects.Add(project);
                }
            }
            reader.Close();
            Connection.Close();
            return projects;

        }

        public bool AssignProjectAndPerson(AssignViewModel assignView)
        {
            string query1 = "INSERT INTO AssignProjectTable Values('" + assignView.ProjectId + "','" + assignView.UserId + "')";
            Command.CommandText = query1;
            Connection.Open();
            bool result = Command.ExecuteNonQuery() > 0;
            Connection.Close();

            string query2 = "UPDATE Project set AssignedTo='" + assignView.UserId+ "' where Id='" + assignView.ProjectId+ "'";
            Command.CommandText = query2;
            Connection.Open();
            bool result2 = Command.ExecuteNonQuery() > 0;
            Connection.Close();

            return result && result2;
        }

    }
}
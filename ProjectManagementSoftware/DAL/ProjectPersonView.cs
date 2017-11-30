using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ProjectManagementSoftware.Models;

namespace ProjectManagementSoftware.DAL
{
    public class ProjectPersonView : ConnectionGateway
    {
        //public List<AssignViewModel> ListofModels()
        //{
        //    Connection.Open();
        //   // string qery = "select pr.Name,ut.Name,ut.Designation from AssignProjectPerson ap join Project pr on pr.Id = ap.ProjectId join UserTable ut on ap.UserId = ut.Id";
        //    string qery = "select * from AssignProjectPerson";
        //    Command.CommandText = qery;
        //    SqlDataReader reader = Command.ExecuteReader();
        //    List<AssignViewModel> assignView = new List<AssignViewModel>();

        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            AssignViewModel assign = new AssignViewModel();
        //            assign.Id = (int)reader["Id"];
        //            assign.ProjectId = (int)reader["ProjectId"];
        //            assign.UserId = (int)reader["UserId"];
        //            assignView.Add(assign);
        //        }
        //    }
        //    reader.Close();
        //    Connection.Close();
        //    return assignView;

        //}

        //public List<AssignViewModel> AssignProject()
        //{
        //    Connection.Open();
        //    string query = "select Pr.Name, ut.Name,des.Name from  AssignProjectTable ap join Project Pr on Pr.Id = ap.projectId join UserTable ut on ut.id =ap.UserId join Designation des on des.Id = ut.Designation";

        //    Command.CommandText = query;

        //    List<AssignViewModel> assignViews = new List<AssignViewModel>();
        //    SqlDataReader reader = Command.ExecuteReader();

        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            AssignViewModel assignView = new AssignViewModel();

        //            assignView.Id = (int) reader["Id"];
        //            assignView.ProjectId = (int) reader["ProjectId"];
        //            assignView.UserId = (int) reader["UserId"];

        //            assignViews.Add(assignView);
        //        }
        //    }
        //    reader.Close();
        //    Connection.Close();
        //    return assignViews;
        //}

        



    }
}
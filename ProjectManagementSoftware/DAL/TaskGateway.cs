using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ProjectManagementSoftware.Models;

namespace ProjectManagementSoftware.DAL
{
    public class TaskGateway: ConnectionGateway
    {
        public int Save(TaskAdd task)
        {
            Connection.Open();

            string query = "Insert into Task values('"+ task.ProjectId+"','"+task.UserId +"','"+ task.Description+"','"+task.DueDate +"','"+task.Priority +"')";


            Command.CommandText = query;
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public List<TaskAdd> AllTasks()
        {
            Connection.Open();
            string query = "Select * from Task";

            Command.CommandText = query;
            List<TaskAdd> listoftask = new List<TaskAdd>();
            SqlDataReader reader = Command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TaskAdd task = new TaskAdd();
                    task.Id = (int) reader["Id"];
                    task.Description = reader["Description"].ToString();
                    listoftask.Add(task);
                }
            }
            reader.Close();
            Connection.Close();

            return listoftask;
        }

    }
}
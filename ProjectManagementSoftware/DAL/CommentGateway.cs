using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectManagementSoftware.Models;

namespace ProjectManagementSoftware.DAL
{
    public class CommentGateway: ConnectionGateway
    {

        public int AddComment(CommentAdd comment)
        {
            Connection.Open();
            string query = "Insert into Comment Values ('"+comment.ProjectId +"','"+comment.TaskId +"','"+comment.Comments +"')";

            Command.CommandText = query;
            int rowaffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowaffected;
        }
    }
}
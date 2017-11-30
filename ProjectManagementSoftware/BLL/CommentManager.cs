using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectManagementSoftware.DAL;
using ProjectManagementSoftware.Models;

namespace ProjectManagementSoftware.BLL
{
    public class CommentManager
    {
        CommentGateway commentGateway = new CommentGateway();

        public int AddComment(CommentAdd comment)
        {
            return commentGateway.AddComment(comment);
        }
    }
}
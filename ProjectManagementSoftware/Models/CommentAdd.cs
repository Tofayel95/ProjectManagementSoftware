using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagementSoftware.Models
{
    public class CommentAdd
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int TaskId { get; set; }
        public string Comments { get; set; }
    }
}
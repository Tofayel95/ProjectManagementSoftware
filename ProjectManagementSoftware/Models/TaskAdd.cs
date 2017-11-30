using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagementSoftware.Models
{
    public class TaskAdd
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }


    }
}
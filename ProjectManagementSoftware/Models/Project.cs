using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagementSoftware.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Duration { get; set; }

        public string Status { get; set; }

        public string AssignTo { get; set; }


    }
}
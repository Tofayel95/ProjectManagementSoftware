using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagementSoftware.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public int DesignationId { get; set; }


    }
}
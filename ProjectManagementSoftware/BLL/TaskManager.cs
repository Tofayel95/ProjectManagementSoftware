using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectManagementSoftware.DAL;
using ProjectManagementSoftware.Models;

namespace ProjectManagementSoftware.BLL
{
    public class TaskManager
    {
        TaskGateway taskGateway = new TaskGateway();
        public int Save(TaskAdd task)
        {
            return taskGateway.Save(task);
        }

        public List<TaskAdd> Listoftask()
        {
            return taskGateway.AllTasks();
        }

    }
}
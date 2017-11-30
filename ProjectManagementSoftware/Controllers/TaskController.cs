using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ProjectManagementSoftware.BLL;
using ProjectManagementSoftware.DAL;
using ProjectManagementSoftware.Models;

namespace ProjectManagementSoftware.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task

        ProjectManager project = new ProjectManager();
        TaskManager _taskManager = new TaskManager();
        UserManager _userManager = new UserManager();
        CommentManager commentManager = new CommentManager();
        public ActionResult ViewComment()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Save()
        {
         ViewBag.Projects =   project.ListofProjects();
            ViewBag.Users = _userManager.listofusers();
            return View();
        }

        [HttpPost]
        public ActionResult Save(TaskAdd task)
        {
            ViewBag.Projects = project.ListofProjects();
            ViewBag.Users = _userManager.Listofpersons();
            _taskManager.Save(task);
            
            return View();
        }

        [HttpGet]
        public ActionResult Comment()
        {
            ViewBag.Projects = project.ListofProjects();
            ViewBag.Tasks = _taskManager.Listoftask();
            return View();
        }

        [HttpPost]
        public ActionResult Comment(CommentAdd comment)
        {

            ViewBag.Projects = project.ListofProjects();
            ViewBag.Tasks = _taskManager.Listoftask();

            commentManager.AddComment(comment);
            return View();
        }


    }
}
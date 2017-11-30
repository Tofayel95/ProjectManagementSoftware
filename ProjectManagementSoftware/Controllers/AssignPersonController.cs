using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectManagementSoftware.BLL;
using ProjectManagementSoftware.DAL;
using ProjectManagementSoftware.Models;

namespace ProjectManagementSoftware.Controllers
{
    public class AssignPersonController : Controller
    {
        ProjectManager projectManager = new ProjectManager();

        UserManager userManager = new UserManager();
        ProjectAssignManager projectAssign = new ProjectAssignManager();
        ProjectPersonView projects = new ProjectPersonView();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Assign()
        {
          ViewBag.Projects =  projectManager.ListofProjects();
          ViewBag.Persons = userManager.Listofpersons();
       

            return View();
        }

        [HttpPost]
        public ActionResult Assign(AssignViewModel assign)
        {

            ViewBag.Projects = projectManager.ListofProjects();
            ViewBag.Persons = userManager.Listofpersons();

            projectManager.AssignPerson(assign);
            return View();
        }
    }
}
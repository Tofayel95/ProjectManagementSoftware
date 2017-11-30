using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectManagementSoftware.BLL;
using ProjectManagementSoftware.Models;

namespace ProjectManagementSoftware.Controllers
{
    public class ProjectController : Controller
    {
        ProjectManager projectManager = new ProjectManager();

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Project project, HttpPostedFileBase file)
        {
            projectManager.Save(project);

            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/UploadedFiles"), fileName);
                file.SaveAs(path);
            }
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

      

    }
}
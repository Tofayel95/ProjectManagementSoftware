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
    public class UserController : Controller
    {

        UserGateway userGateway = new UserGateway();
        UserManager userManager = new UserManager();
        ProjectAssignManager projectAssign = new ProjectAssignManager();


        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Save()
        {
            ViewBag.Designationlist =  userGateway.Designationlist();
            ViewBag.UserInfo = userManager.listofusers();
           
            return View();
        }

        [HttpPost]
        public ActionResult Save(UserDetails user)
        {
           
            ViewBag.Designationlist = userGateway.Designationlist();
            ViewBag.UserInfo = userManager.listofusers();
            if (userGateway.EmailAvailabel(user) == null)
            {
                int rowAffected = userGateway.Save(user);
                if (rowAffected > 0)
                {
                    ViewBag.SuccessMessage = "User Saved Successfully";
                }
            }
            else
            {
                ViewBag.ErrorMessage = "User doesnot Saved ";
            }           
            return View();
        }
    }
}
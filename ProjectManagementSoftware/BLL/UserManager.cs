using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectManagementSoftware.DAL;
using ProjectManagementSoftware.Models;

namespace ProjectManagementSoftware.BLL
{
    public class UserManager
    {
        UserGateway userGateway = new UserGateway();

        public List<UserDetails> listofusers()
        {
            return userGateway.ShowDetail();
        }


        public List<UserDetails> Listofpersons()
        {
            return userGateway.ListofPerson();
        }


        public string EmailAvailabel(UserDetails user)
        {
            return userGateway.EmailAvailabel(user);
        }

    }
}
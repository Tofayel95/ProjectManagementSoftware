using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using ProjectManagementSoftware.Models;

namespace ProjectManagementSoftware.DAL
{
    public class UserGateway : ConnectionGateway
    {
        public string Message { get; set; }
        public int Save(UserDetails user)
        {
            Connection.Open();

            string query = "Insert into UserTable values('" + user.Name + "','" + user.Email + "','" + user.Password + "','" + user.Status + "','" + user.DesignationId + "')";
            Command.CommandText = query;
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;

        }

        public List<UserDetails> ListofPerson()
        {
            Connection.Open();
            string query = "select * from UserTable";

            Command.CommandText = query;
            List<UserDetails> users = new List<UserDetails>();

            SqlDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    UserDetails user = new UserDetails();
                    user.Id = (int)reader["Id"];
                    user.Name = reader["Name"].ToString();
                    user.Email = reader["Email"].ToString();
                    users.Add(user);
                }
            }
            reader.Close();
            Connection.Close();
            return users;

        }

        public List<Designation> Designationlist()
        {
            Connection.Open();
            string query = "Select * from Designation";
            Command.CommandText = query;

            List<Designation> listofDesignation = new List<Designation>();
            SqlDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Designation designation = new Designation();
                    designation.Id = (int) reader["Id"];
                    designation.Name = reader["Name"].ToString();
                    listofDesignation.Add(designation);
                }
            }
            reader.Close();
            Connection.Close();
            return listofDesignation;
        }

        public List<UserDetails> ShowDetail()
        {
            Connection.Open();
            string query = "select ut.Name,ut.Email,ut.Password , dg.Name as Designation,ut.Status from UserTable ut join designation dg on ut.Designation = dg.Id";
            //string query = "Select * from UserTable";
            Command.CommandText = query;

            List<UserDetails> details = new List<UserDetails>();
            SqlDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    UserDetails user = new UserDetails();

                    user.Name = reader["Name"].ToString();
                    user.Email = reader["Email"].ToString();
                    user.Password = reader["Password"].ToString();
                    user.Status = reader["Status"].ToString();
                 //   user.DesignationId = (int) reader["Designation"];
                                                         
                    details.Add(user);
                }
            }
            reader.Close();
            Connection.Close();
            return details;
        }

        public string EmailAvailabel(UserDetails newuser)
        {
            Connection.Open();
            string query = "Select * from UserTable where Email = '" + newuser.Email + "'";
            Command.CommandText = query;

            SqlDataReader reader = Command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Message = "Email in use";
                    UserDetails user = new UserDetails();
                    user.Id = (int)reader["Id"];
                    user.Name = reader["Name"].ToString();
                    user.Email = reader["Email"].ToString();
                }
            }
            reader.Close();
            Connection.Close();
            return Message;
        }

    }
}
using CapstonePets.DataAccess.Shared;
using CapstonePets.Models;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CapstonePets.DataAccess
{
    public class OwnerDBAccessLayer
    {
        public static string RESULT { get; set; }
        public static string SUCCESS => "Sucess";

        SqlConnection con = new SqlConnection(SqlDataAccess.GetConnectionString());

        public string AddOwnerRecord(OwnerModel ownerModel)
        {
            try
            {
                //TO DO: Create stored procedure for adding an owner, verify the fields
                SqlCommand cmd = new SqlCommand("spAddOwnerRecord", con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@strFirstName", ownerModel.strFirstName);
                cmd.Parameters.AddWithValue("@strLastName", ownerModel.strLastName);
                cmd.Parameters.AddWithValue("@strAddress", ownerModel.strAddress);
                cmd.Parameters.AddWithValue("@intStateID", ownerModel.intStateID);
                cmd.Parameters.AddWithValue("@strCity", ownerModel.strCity);
                cmd.Parameters.AddWithValue("@strZip", ownerModel.strZip);
                cmd.Parameters.AddWithValue("@strEmail", ownerModel.strEmail);
                cmd.Parameters.AddWithValue("@intGenderID", ownerModel.intGenderID);
                cmd.Parameters.AddWithValue("@strPhoneNumber", ownerModel.strPhoneNumber);
                cmd.Parameters.AddWithValue("@strSecondaryOwnerName", ownerModel.strSecondaryOwnerName);
                cmd.Parameters.AddWithValue("@strSecondaryOwnerPhoneNumber", ownerModel.strSecondaryOwnerPhoneNumber);
                cmd.Parameters.AddWithValue("@strSecondaryOwnerEmailAddress", ownerModel.strSecondaryOwnerEmailAddress);
                cmd.Parameters.AddWithValue("@strNotes", ownerModel.strNotes);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                return RESULT = SUCCESS;
            }
            catch (Exception ex)
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                return (ex.Message.ToString());
            }
        }

        public string DeleteOwnerRecord(int id)
        {
            //TO DO: Add Logic here
            return RESULT = SUCCESS;
        }

        public string UpdateOwnerRecord(OwnerModel ownerModel)
        {
            //TO DO: Add Logic here
            return RESULT = SUCCESS;
        }

        public List<OwnerModel> LoadOwners()
        {
            //TO DO: Add query string here
            string sql = @"";
            return SqlDataAccess.LoadData<OwnerModel>(sql);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Stryker_WasteManagement.Models
{
    public class UserModel
    {
        [Required]
        [DisplayName("Username")]
        public string userName { get; set; }

        [Required]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }



        public DataTable userDetails(string username, string password)

        {
            SqlConnection conn = new SqlConnection(@"server=LP-F8CAB8595B27\SQLEXPRESS;Initial Catalog=test;User Id=sa;Password=April20!6");

            SqlCommand cmd = new SqlCommand("select * from User_Login where Username=@user and User_Pass=@pass", conn);

            cmd.Parameters.AddWithValue("@user", username);

            cmd.Parameters.AddWithValue("@pass", password);


            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);


            return dt;

        }
    }
}
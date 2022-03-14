using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Project_demo.Model;
using Project_demo.Service;

namespace Project_demo.Repository
{
    public class RepositoryMembers
    {
        public static bool addMember(Members Members)
        {
            String dbInfo = "server=localhost;userid=root;password=;database=project_demo";

            MySqlConnection db = new MySqlConnection(dbInfo);

            db.Open();

            string sql = "INSERT INTO addmember (FName,LName,Gender,Dob,Phone,Email,JoinDate,GymTime,Maddress,MembershipTime) VALUES (@Fname,@Lname,@Gender,@Dob,@Phone,@Email,@JoinDate,@Gymtime,@Maddress,@Membership)";
            MySqlCommand command = new MySqlCommand(sql, db);

            command.Parameters.AddWithValue("Fname",Members.Fname);
            command.Parameters.AddWithValue("Lname",Members.Lname);
            command.Parameters.AddWithValue ("Gender",Members.Gender);
            command.Parameters.AddWithValue("Dob", Members.Dob);
            command.Parameters.AddWithValue("Phone", Members.Phone);
            command.Parameters.AddWithValue("Email", Members.Email);
            command.Parameters.AddWithValue("JoinDate", Members.JoinDate);
            command.Parameters.AddWithValue("Gymtime", Members.Gymtime);
            command.Parameters.AddWithValue("Maddress", Members.Maddress);
            command.Parameters.AddWithValue("Membership", Members.Membership);


            command.ExecuteNonQuery();
            db.Close();

            return true;
        }
    }
}

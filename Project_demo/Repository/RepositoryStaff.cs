using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Project_demo.Model;
using Project_demo.Repository;
using Project_demo.Service;



namespace Project_demo.Repository
{
    public class RepositoryStaff
    {
        public static bool addStaff(Staff Staff)
        {
            String dbInfo = "server=localhost;userid=root;password=;database=project_demo";

            MySqlConnection db = new MySqlConnection(dbInfo);

            db.Open();

            string sql = "INSERT INTO addstaff (FName,LName,Gender,Dob,Phone,Email,JoinDate,Saddress,Job) VALUES (@Fname,@Lname,@Gender,@Dob,@Phone,@Email,@JoinDate,@Saddress,@Job)";
            MySqlCommand command = new MySqlCommand(sql, db);

            command.Parameters.AddWithValue("Fname", Staff.Fname);
            command.Parameters.AddWithValue("Lname", Staff.Lname);
            command.Parameters.AddWithValue("Gender", Staff.Gender);
            command.Parameters.AddWithValue("Dob", Staff.Dob);
            command.Parameters.AddWithValue("Phone", Staff.Phone);
            command.Parameters.AddWithValue("Email", Staff.Email);
            command.Parameters.AddWithValue("JoinDate", Staff.JoinDate);
            command.Parameters.AddWithValue("Saddress", Staff.Saddress);
            command.Parameters.AddWithValue("Job", Staff.Job);


            command.ExecuteNonQuery();
            db.Close();

            return true;
        }
    }
}

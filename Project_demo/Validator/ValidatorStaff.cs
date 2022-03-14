using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_demo.Model;

namespace Project_demo.Validator
{
    internal class ValidatorStaff
    {
        public static List<String> errorsStaff = new List<String>();
        public static bool isValidData(Staff Staff)
        {
            errorsStaff.Clear();
            checkFnameStaff(Staff.Fname);
            checkLnameStaff(Staff.Lname);
            checkGenderStaff(Staff.Gender);
            checkDobStaff(Staff.Dob);
            checkPhoneStaff(Staff.Phone);
            checkEmailStaff(Staff.Email);
            checkJoinDateStaff(Staff.JoinDate);
            checkSaddress(Staff.Saddress);
            checkJob(Staff.Job);
            


            if (errorsStaff.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void checkFnameStaff(string fname)
        {
            if (fname == "")
            {
                errorsStaff.Add("Please enter first name!");
            }
        }
        private static void checkLnameStaff(string lname)
        {
            if (lname == "")
            {
                errorsStaff.Add("Please enter last name!");
            }
        }
        private static void checkGenderStaff(string gender)
        {
            if (gender == "")
            {
                errorsStaff.Add("Please select gender!");
            }
        }
        private static void checkDobStaff(string dob)
        {
            if (dob == "")
            {
                errorsStaff.Add("Please enter your date of birth!");
            }
        }
        private static void checkPhoneStaff(string phone)
        {
            if (phone == "")
            {
                errorsStaff.Add("Please enter your mobile phone number!");
            }
        }
        private static void checkEmailStaff(string emailaddress)
        {
            if (emailaddress == "")
            {
                errorsStaff.Add("Please enter a valid email address!");
            }
        }
        private static void checkJoinDateStaff(string jd)
        {
            if (jd == "")
            {
                errorsStaff.Add("Please enter a valid join date!");
            }
        }
        private static void checkSaddress(string Saddress)
        {
            if (Saddress == "")
            {
                errorsStaff.Add("Please enter your Address!");
            }
        }
        private static void checkJob(string jb)
        {
            if (jb == "")
            {
                errorsStaff.Add("Please select position!");
            }
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_demo.Model;

namespace Project_demo.Validator
{
    internal class ValidatorMembers
    {
        public static List<String> errors = new List<String>();
        public static bool isValidData(Members Members)
        {
            errors.Clear();
            checkFname(Members.Fname);
            checkLname(Members.Lname);
            checkGender(Members.Gender);
            checkDob(Members.Dob);
            checkPhone(Members.Phone);
            checkEmail(Members.Email);
            checkJoinDate(Members.JoinDate);
            checkGymTime(Members.Gymtime);
            checkMaddress(Members.Maddress);
            checkMembershipTime(Members.Membership);


            if (errors.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void checkFname(string fname)
        {
            if (fname == "")
            {
                errors.Add("Please enter first name!");
            }
        }
        private static void checkLname(string lname)
        {
            if (lname == "")
            {
                errors.Add("Please enter last name!");
            }
        }
        private static void checkGender(string gender)
        {
            if (gender == "")
            {
                errors.Add("Please select gender!");
            }
        }
        private static void checkDob(string dob)
        {
            if (dob == "")
            {
                errors.Add("Please enter your date of birth!");
            }
        }
        private static void checkPhone(string phone)
        {
            if (phone == "")
            {
                errors.Add("Please enter your mobile phone number!");
            }
        }
        private static void checkEmail(string emailaddress)
        {
            if (emailaddress == "")
            {
                errors.Add("Please enter a valid email address!");
            }
        }
        private static void checkJoinDate(string jd)
        {
            if (jd == "")
            {
                errors.Add("Please enter a valid join date!");
            }
        }
        private static void checkGymTime(string gt)
        {
            if (gt == "")
            {
                errors.Add("Please select a valid gym Time!");
            }
        }
        private static void checkMaddress(string name)
        {
            if (name == "")
            {
                errors.Add("Please enter your address!");
            }
        }
        private static void checkMembershipTime(string mtime)
        {
            if (mtime == "")
            {
                errors.Add("Please select the duration of the membership!");
            }
        }
    }
}

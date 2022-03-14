using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_demo.Model
{
    public class Members
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Gender { get; set; }
        public string Dob { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string JoinDate { get; set; }
        public string Gymtime { get; set; }
        public string Maddress { get; set; }
        public string Membership { get; set; }

        public Members(string fname, string lname, string gender, string dob, string phone, string email, string joinDate, string gymtime, string maddress, string membership)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Gender = gender;
            this.Dob = dob;
            this.Phone = phone; 
            this.Email = email;
            this.JoinDate = joinDate;
            this.Gymtime = gymtime;
            this.Maddress = maddress;
            this.Membership = membership;
        }

    }
}

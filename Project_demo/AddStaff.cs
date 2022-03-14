using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_demo.Service;
using Project_demo.Model;
using Project_demo.Validator;

namespace Project_demo
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();

            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;

            dateTimePickerDoB.Value = DateTime.Now;
            dateTimePickerJD.Value = DateTime.Now;

            txtPhone.Clear();
            txtSaddress.Clear();
            txtEmail.Clear();
            txtJob.Clear();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            String fname = txtFirstName.Text;
            String lname = txtLastName.Text;

            String gender = "";

            bool isChecked = radioButtonMale.Checked;
            bool isChecked2 = radioButtonFemale.Checked;

            if (isChecked)
            {
                gender = radioButtonMale.Text;
            }
            else if (isChecked2)
            {
                gender = radioButtonFemale.Text;
            }

            String dob = dateTimePickerDoB.Text;
            String phone = txtPhone.Text;
            String email = txtEmail.Text;
            String joinDate = dateTimePickerJD.Text;
            String saddress = txtSaddress.Text;
            String job = txtJob.Text;


            if (ServiceStaff.Add(new Staff(fname, lname, gender, dob, phone, email, joinDate,saddress,job)))
            {
                MessageBox.Show("Added");

                // InfoBox.Text = ServiceMember.GetAll();
            }
            else
            {
                string text = "Error";

                List<String> errorsStaff = ValidatorStaff.errorsStaff;
                for (int i = 0; i < errorsStaff.Count; i++)
                {
                    text += "\n";
                    text += errorsStaff[i];
                    text += "\n";
                }
                MessageBox.Show(text);

            }
        }
    }
    
}

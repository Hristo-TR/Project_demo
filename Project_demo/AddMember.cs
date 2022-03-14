using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Project_demo.Service;
using Project_demo.Model;
using Project_demo.Repository;
using Project_demo.Validator;


namespace Project_demo
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void Textbox1_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String fname = txtFirstName.Text;
            String lname = txtLastName.Text;

            String gender = "";

            bool isChecked = radioButton1.Checked;
            bool isChecked2 = radioButton2.Checked;

            if (isChecked)
            {
                gender = radioButton1.Text;
            }
            else if (isChecked2)
            {
                gender = radioButton2.Text;
            }

            String dob = dateTimePickerDOB.Text;
            String phone = txtPhone.Text;
            String email = txtEmail.Text;
            String joinDate = dateTimePickerJoinDate.Text;
            String gymTime = comboBoxGymTime.Text;
            String address = txtAddress.Text;
            String membership = comboBoxMembership.Text; 

            if (ServiceMembers.Add(new Members(fname,lname, gender,dob,phone,email,joinDate,gymTime,address,membership)))
            {
                MessageBox.Show("Added");
               
               // InfoBox.Text = ServiceMember.GetAll();
            }
            else
            {
                string text = "Error";

                List <String> errros = ValidatorMembers.errors;
                for (int i = 0; i < errros.Count; i++)
                {
                    text += "\n";
                    text += errros[i];
                    text += "\n";
                }
                MessageBox.Show(text);

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;
            
            txtPhone.Clear();
            txtAddress.Clear();
            txtEmail.Clear();

            comboBoxGymTime.ResetText();
            comboBoxMembership.ResetText();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_demo.Model;
using Project_demo.Service;
using Project_demo.Repository;
using Project_demo.Validator;

namespace Project_demo
{
    public partial class EquipmentForm : Form
    {
        public EquipmentForm()
        {
            InitializeComponent();
        }

        private void Equipment_Load(object sender, EventArgs e)
        {
         
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String description = txtDescription.Text;
            String deliverydate = dateTimePickerDeliveryDate.Text;
            String muscleused = txtMuscle.Text;
            String cost = txtCost.Text;

            if (ServiceEquipment.Add(new Equipments(name, description, deliverydate, muscleused, int.Parse(cost))))
            {
                MessageBox.Show("Added");

                // InfoBox.Text = ServiceMember.GetAll();
            }
            else
            {
                string text = "Error";

                List<String> errros = ValidatorEquipment.errorsEquipment;
                for (int i = 0; i < errros.Count; i++)
                {
                    text += "\n";
                    text += errros[i];
                    text += "\n";
                }
                MessageBox.Show(text);

            }
        }
    }
}

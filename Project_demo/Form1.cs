using System.Windows.Forms;
using System.Threading.Tasks;

namespace Project_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddStaff ad = new AddStaff();
            ad.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMember ad = new AddMember();
            ad.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Log OUT !! Confirm?","LOG OUT",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                Login lg = new Login();
                    lg.Show();

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close your application ! Confirm?", "CLOSE",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome Back", "Welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_equipment_Click(object sender, EventArgs e)
        {

        }
    }

   
}
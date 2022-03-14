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
    }

   
}
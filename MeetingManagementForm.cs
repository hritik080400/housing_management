using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace housing_management
{
    public partial class MeetingManagementForm : Form
    {
        public MeetingManagementForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MeetingManagementForm_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;

            // first get the first day of the month

            DateTime starOfTheMont = new DateTime(now.Year,now.Month,1);
            //get the count of days of the month
            int days = DateTime.DaysInMonth(now.Year,now.Month);
            //conver the start of the mont into int
            int dayOfTheWeek = Convert.ToInt32(starOfTheMont.DayOfWeek.ToString("d"))+1;

            // first  create blank usercontrol
            for(int i =1; i < days; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                dateContainer.Controls.Add(userControlBlank);
            }
        }
    }
}

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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            customizeDesing(); 
        }

        private void customizeDesing()
        {
            //panelDashBoardSubMenu.Visible = false;
            //subMenuWingManagement.Visible = false;
            subMenuNotice.Visible = false;
            subMenuMeetings.Visible = false;
            subMenuFacility.Visible = false;
        }

        private void hideSubMenu()
        {
            //if (subMenuWingManagement.Visible == true)
            //{
            //    subMenuWingManagement.Visible = false;
            //}

            if(subMenuNotice.Visible == true)
            {
                subMenuNotice.Visible = false;
            }

            if(subMenuMeetings.Visible == true)
            {
                subMenuMeetings.Visible = false;
            }

            if (subMenuFacility.Visible == true)
            {
                subMenuFacility.Visible = false;
            }


        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;

            }
            else
            {
                subMenu.Visible = false;
            }
        }



        private void DashboardBtn_Click_1(object sender, EventArgs e)
        {
            DashboardBtn.BackColor = Color.White;

        }

        private void btnWingManagement_Click(object sender, EventArgs e)
        {
           
            openChildForm(new wingsManagement());
            MessageBox.Show("Hello Hritik");

        }
        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new MeetingManagementForm());

        }

        private void btnMember_Management_Click(object sender, EventArgs e)
        {
            

        }
        private void btnMeeting_Managements_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuMeetings);

        }
        private void btnFacilityManagement_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuFacility);

        }

        private void btnNoticeManagement_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuNotice);

        }


        //private Form activeForm=null;
        private void openChildForm( object childForm)
        {
            if(this.panelChildForm.Controls.Count>0)
                this.panelChildForm.Controls.RemoveAt(0);
            Form f = childForm as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelChildForm.Controls.Add(f);
            this.panelChildForm.Tag = f;
            f.Show();




            //if(activeForm != null)
            //{
            //    activeForm.Close();
               
            //}
            //activeForm = childForm;
            //childForm.TopLevel = false;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            //panelChildForm.Controls.Add(childForm);
            //panelChildForm.Tag = childForm;
            ////childForm.BringToFront();
            //childForm.Show();

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}

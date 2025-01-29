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
    public partial class wingsManagement : Form
    {
        public wingsManagement()
        {
            InitializeComponent();
            
        }


        private void siticoneButton1_Click_2(object sender, EventArgs e)
        {
            // Create a semi-transparent background overlay
            Form formBackGround = new Form();
            try
            {
                // Configure the background overlay form
                formBackGround.StartPosition = FormStartPosition.Manual;
                formBackGround.FormBorderStyle = FormBorderStyle.None;
                formBackGround.Opacity = 0.7d; // Semi-transparent
                formBackGround.BackColor = Color.Black;
                formBackGround.WindowState = FormWindowState.Maximized;
                formBackGround.TopMost = true;
                formBackGround.Location = this.Location;
                formBackGround.ShowInTaskbar = false;

                // Display the background overlay
                formBackGround.Show();

                // Create and configure the AddWing form
                using (AddWing addWingForm = new AddWing())
                {
                    addWingForm.StartPosition = FormStartPosition.CenterScreen;

                    // Show the AddWing form as a modal dialog
                    if (addWingForm.ShowDialog() == DialogResult.OK)
                    {
                        // Handle successful data addition if needed
                        MessageBox.Show("Wing added successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Dispose of the background overlay
                formBackGround.Dispose();
            }

        }

        private void siticoneImageButton3_Click(object sender, EventArgs e)
        {
            if (containerFilter.Visible == false)
            {
                containerFilter.Visible = true;

            }
            else
            {
                containerFilter.Visible = false;

            }

        }

        private void containerFilter_Click(object sender, EventArgs e)
        {

        }

        private void wingsManagement_Load(object sender, EventArgs e)
        {
            containerFilter.Visible = false;

        }
    }
}

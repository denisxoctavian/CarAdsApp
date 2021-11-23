using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoAdUI
{  //Home Page
    public partial class Form1 : Form
    {
        public Form activeForm = null;

        public Form1()
        {
            InitializeComponent();
            customDesign();  
        }

        //Custom form design 
        private void customDesign()
        {
            panelAdSub.Visible = false;
        }

        //This method hides submenu.
        private void hideSub()
        {
            if(panelAdSub.Visible == true)
            {
                panelAdSub.Visible = false;
            }
        }

        //This method shows submenu.
        private void showSub(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSub();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        //Open ad's menu
        private void buttonAd_Click(object sender, EventArgs e)
        {
            showSub(panelAdSub);
        }

        //Open adcreate-page
        private void button_createAd_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            hideSub();
        }

        //Open ads-page
        private void buttonAds_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
        }


        //Open aboutus-page
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            openChildForm(new Form5());
        }

        //This method open a new form in panelChildForm panel
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
    }
}

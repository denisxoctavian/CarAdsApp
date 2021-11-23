using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoAdUI
{  //View ad page
    
    public partial class Form3 : Form
    {
        public string modelForEdit;
        public int indexPic;
        public int numberOfPics;
        public Form activeForm = null;
        public Form3()
        {
            InitializeComponent();
            LoadImage();
            CustomDesign();
            numberOfPics = 0;
        }

        //This method loads the first pic into the PictureBox.
        public void LoadImage()
        {
            string[] folderPics; // Ad_id folder
            string[] pics;

            foreach (var folderChild in Global.folderChilds)
            {
                if (Path.GetFileName(folderChild)=="Ad_"+Global.globalId)
                {
                    folderPics = Directory.GetDirectories(folderChild, "pics");
                    pics = Directory.GetFiles(folderPics[0]);
                    pictureBox1.Image = new Bitmap(pics[0]);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    numberOfPics++; 
                }
            }
        }

        //Hide previous button , show next button.
        public void CustomDesign()
        {
            label_Next.Visible = true;
            label_Previous.Visible = false;
        }

        //I used labels instead of buttons because of the hover effect.
        //Back button hover design 
        private void label_Back_MouseEnter(object sender, EventArgs e)
        {
            label_Back.ForeColor = Color.FromArgb(255, 183, 100);
        }

        //Back button hover design 
        private void label_Back_MouseLeave(object sender, EventArgs e)
        {
            label_Back.ForeColor = Color.FromArgb(255, 128, 0);
        }

        //Back button functionality
        private void label_Back_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4()); 
        }

        //Delete button hover design
        private void label_Delete_MouseEnter(object sender, EventArgs e)
        {
            label_Delete.ForeColor = Color.FromArgb(255, 183, 100);
        }

        //Delete button hover design
        private void label_Delete_MouseLeave(object sender, EventArgs e)
        {
            label_Delete.ForeColor = Color.FromArgb(255, 128, 0);
        }

        //Delete button functionality
        private void label_Delete_Click(object sender, EventArgs e)
        {

           
            string fileName;
  
            foreach (var folderChild in Global.folderChilds)
            {
                fileName = Path.GetFileName(folderChild);
               
                if (fileName.Contains(label_Ad.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the ad?", "Question", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Directory.Delete(folderChild, true);
                        openChildForm(new Form4());
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
        }
        //Edit button hover design
        private void label_Edit_MouseEnter(object sender, EventArgs e)
        {
            label_Edit.ForeColor = Color.FromArgb(255, 183, 100);
        }
        //Edit button hover design
        private void label_Edit_MouseLeave(object sender, EventArgs e)
        {
            label_Edit.ForeColor = Color.FromArgb(255, 128, 0);
        }
        //Edit button functionality
        private void label_Edit_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.textBox_id.Text = label_Ad.Text;
            f2.textBox_id.ReadOnly = true; // Id can't be edited !
            f2.comboBox_adType.Text = label_AdType.Text;
            if (label_AdType.Text == "Sell")
            {
                f2.comboBox_adType.SelectedIndex = 1;
            }
            else
            {
                f2.comboBox_adType.SelectedIndex = 0;
            }
            f2.textBox_brand.Text = label_Brand.Text.Replace(modelForEdit, "");
            f2.textBox_model.Text = modelForEdit;
            f2.textBox_price.Text = label_Price.Text.Replace("\u20AC", "");
            f2.textBox_year.Text = label_Year.Text;
            f2.textBox_fuel.Text = label_Fuel.Text;
            f2.textBox_desc.Text = richTextBox_desc.Text;
            f2.button_Save.Visible = false;
            f2.button_Add.Text = "Edit ad";
            openChildForm(f2);
        }


        //Next button hover design 
        private void label_Next_MouseEnter(object sender, EventArgs e)
        {
            label_Next.ForeColor = Color.FromArgb(255, 183, 100);
        }

        //Next button hover design 
        private void label_Next_MouseLeave(object sender, EventArgs e)
        {
            label_Next.ForeColor = Color.FromArgb(255, 128, 0);
        }

        //Next button functionality
        private void label_Next_Click(object sender, EventArgs e)
        {
            
            string[] folderPics;
            string[] pics;

            foreach (var folderChild in Global.folderChilds)
            {
                if (Path.GetFileName(folderChild) == "Ad_" + Global.globalId)
                {
                    
                    folderPics = Directory.GetDirectories(folderChild, "pics");
                    pics = Directory.GetFiles(folderPics[0]);
                    indexPic++;
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = new Bitmap(pics[indexPic]);
                    if (indexPic > 0 )
                        label_Previous.Visible = true;
                    
                    if (indexPic == numberOfPics+1)
                        label_Next.Visible = false;
                }
                }
            }


        //Previous button hover design
        private void label_Previous_MouseEnter(object sender, EventArgs e)
        {
            label_Previous.ForeColor = Color.FromArgb(255, 183, 100);
        }

        //Previous button hover design
        private void label_Previous_MouseLeave(object sender, EventArgs e)
        {
            label_Previous.ForeColor = Color.FromArgb(255, 128, 0);
        }

        //Previous button functionality
        private void label_Previous_Click(object sender, EventArgs e)
        {
            
            string[] folderPics;
            string[] pics;

            foreach (var folderChild in Global.folderChilds)
            {
                if (Path.GetFileName(folderChild) == "Ad_" + Global.globalId)
                {

                    folderPics = Directory.GetDirectories(folderChild, "pics");
                    pics = Directory.GetFiles(folderPics[0]);
                    
                    if (label_Next.Visible == false)
                        label_Next.Visible = true;

                    indexPic--;
                    
                    if (indexPic == 0)
                        label_Previous.Visible = false;

                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = new Bitmap(pics[indexPic]);
                    
                }

                }
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


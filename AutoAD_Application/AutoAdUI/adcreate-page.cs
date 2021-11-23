using AutoAdModel;
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
using System.Windows.Documents;
using System.Windows.Forms;


namespace AutoAdUI
{
    public partial class Form2 : Form
    {
        public AutoAdList Ads = new AutoAdList(); // List of ads
        List<string> picsUploaded = new List<string>(); //List of pics (string)
      
        public Form2()
        {  
            InitializeComponent();
            LoadComboBox(); 
        }

        //This method loads into the ComboBox the choices from Enumaration.
        public void LoadComboBox()
        {
            foreach(var item in Enum.GetValues(typeof(AdType)))
            {
                comboBox_adType.Items.Add(item);
            }
        }

        //This clears all textboxes after we save an object to list
        public void Clear()
        {
            textBox_id.Clear();
            textBox_brand.Clear();
            textBox_price.Clear();
            textBox_year.Clear();
            textBox_model.Clear();
            textBox_fuel.Clear();
            textBox_desc.Clear();
                   
        }

        //This methods checks if an id is already used or not.
        private bool checkIDS(string Id)
        {
            string fileName;
            foreach (var folderChild in Global.folderChilds)
            {
                fileName = Path.GetFileName(folderChild);

                if (fileName.Contains(Id))
                {
                    return true;
                }
            }
            return false;
        }

        //This method is used for uploading pictures
        private void button_Upload_Click(object sender, EventArgs e)
        {
            int fileNumbers = 0; 
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg;*.bmp;)|*.jpg;*.jpeg;*.bmp;";
            open.Multiselect = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
               foreach(string file in open.FileNames)
                {
                    fileNumbers++; //We count the uploaded pictures
                }
                if(fileNumbers == 1)//For one ad we need atleast two pictures
                {
                    MessageBox.Show("You need to upload atleast two photos!");
                    return;
                }
                picsUploaded = open.FileNames.ToList(); //save the pics locations in a list
            }
        }

        //This method is used to add an ad to Ads list .
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_id.Text)) //checks if the user has input something
            {
                MessageBox.Show("You must enter the id!");
                return;
            }
            
            if(checkIDS(textBox_id.Text) && button_Add.Text !="Edit ad") //checks if the edit mode is not on and the id does not already exist
            {
                MessageBox.Show("There is already an ad with this id.");
                return;
            }

            int id;
            if (!int.TryParse(textBox_id.Text, out id))//checks if the id is a number 
            {
                MessageBox.Show("The id must be a number!");
                return;
            }

            if (string.IsNullOrEmpty(comboBox_adType.Text))//checks if the user has choose something
            {
                MessageBox.Show("You must select a type for the ad!");
                return;
            }

            if (string.IsNullOrEmpty(textBox_brand.Text))//checks if the user has input something
            {
                MessageBox.Show("Enter the brand of the car!");
                return;
            }

            if (string.IsNullOrEmpty(textBox_model.Text))//checks if the user has input something
            {
                MessageBox.Show("Enter the model of the car");
                return;
            }

            if (string.IsNullOrEmpty(textBox_price.Text))//checks if the user has input something
            {
                MessageBox.Show("You must enter the price!");
                return;
            }

            int price;
            if (!int.TryParse(textBox_price.Text, out price))//checks if the user input is a number
            {
                MessageBox.Show("The price must be a number!");
                return;
            }

            if (string.IsNullOrEmpty(textBox_year.Text))//checks if the user has input something
            {
                MessageBox.Show("You must enter the year of fabrication!");
                return;
            }     

            int year;
            if(!int.TryParse(textBox_year.Text, out year))//checks if the user input is a number
            {
                MessageBox.Show("The year of fabrication must be a number!");
                return;
            }

            if (int.Parse(textBox_year.Text) > 2022)//checks if the number entered by the user is less than the current year
            {
                MessageBox.Show("We are not in that year yet!");
                return;
            }

            if (string.IsNullOrEmpty(textBox_fuel.Text))//checks if the user has input something
            {
                MessageBox.Show("You must enter the fuel type!");
                return;
            }

            if (string.IsNullOrEmpty(textBox_desc.Text))//check if the user has input something
            {
                MessageBox.Show("You must write a description about the car!");
                return;
            }

            if(picsUploaded.Count < 2)//checks if user uploaded atleast 2 photos
            {
                MessageBox.Show("You must upload atleast two photo!");
                return;
            }

            AutoAd ad = new AutoAd() //with the constructor we build the object 
            { 
                id = int.Parse(textBox_id.Text),
                AdType = comboBox_adType.SelectedItem.ToString(),
                brand = textBox_brand.Text,
                model = textBox_model.Text,
                price = int.Parse(textBox_price.Text),
                yearOfFabrication = int.Parse(textBox_year.Text),
                fuelType = textBox_fuel.Text,
                description = textBox_desc.Text,
                pics = new List<string>(picsUploaded)
            };

            try
            {
                Ads.Add(ad);//and add it to the list
       
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
             if(button_Add.Text=="Edit ad") // if the edit mode is on an appropriate message is showed  
            {
                MessageBox.Show("Ad edited succesfully!");
                Ads.SaveOnDisk(); // rewrite the ad
            }

        }

        //This method save the ad and show a message
        private void button_Save_Click(object sender, EventArgs e)
        {    
            Ads.SaveOnDisk();
            
                if (button_Save.Text == "Edit ad")//checks if edit mode is on
            {
                MessageBox.Show("Ad edited successfully!");
            }
            else
            {  
                MessageBox.Show("Ads saved!");
                Clear();
            }
        }
    }
}

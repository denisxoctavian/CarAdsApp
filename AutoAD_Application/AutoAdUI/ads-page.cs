using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoAdModel;

namespace AutoAdUI
{
    public partial class Form4 : Form
    {
        public AutoAdModel.AutoAdList AutoAdList { get; private set; }
        public Form activeForm = null;

        public Form4()
        {
            AutoAdList = new AutoAdModel.AutoAdList();
            InitializeComponent();
            AutoAdList.LoadFromDisk();
            UpdateGrid();
            LoadComboBox();
            dataGridView1.ClearSelection();

        }

        //This method updates the DataGridView.
        public void UpdateGrid()
        {
            var bindigList = new BindingList<AutoAd>(AutoAdList.Ads);
            dataGridView1.DataSource = new BindingSource(bindigList, null);
        }

        //This method loads into the ComboBox the choices from Enumeration.
        private void LoadComboBox()
        {
            foreach (var item in Enum.GetValues(typeof(SortType)))
            {
                comboBox_SortBy.Items.Add(item);
            }
        }

        //This method sorts the DataGridView using certain criteria.
        private void button_sortBy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_SortBy.Text)) //check if atleast one criterion was selected
            {
                MessageBox.Show("You must first choose a sorting criterion!");
                return;
            }
            
            string selected = comboBox_SortBy.SelectedItem.ToString();
            var field = (SortType)Enum.Parse(typeof(SortType), selected);
            AutoAdList.SortBy(field);
            UpdateGrid(); 
        }

        //This method is used to filter the DataGridView.
        private void button1_Click(object sender, EventArgs e)
        {
            //validations

            int test;
            if (!string.IsNullOrEmpty(textBox_PriceMin.Text) && !int.TryParse(textBox_PriceMin.Text, out test))
            {
                MessageBox.Show("Minimum price must be a number!");
                return;
            }

            if (!string.IsNullOrEmpty(textBox_PriceMax.Text) && !int.TryParse(textBox_PriceMax.Text, out test))
            {
                MessageBox.Show("Maximum price must be a number!");
                return;
            }

            if (!string.IsNullOrEmpty(textBox_YearMin.Text) && !int.TryParse(textBox_YearMin.Text, out test))
            {
                MessageBox.Show("Minimum year must be a number!");
                return;
            }

            if (!string.IsNullOrEmpty(textBox_YearMax.Text) && !int.TryParse(textBox_YearMax.Text, out test))
            {
                MessageBox.Show("Maximum year must be a number!");
                return;
            }

            if (string.IsNullOrEmpty(textBox_PriceMin.Text) && !string.IsNullOrEmpty(textBox_PriceMax.Text))
            {
                MessageBox.Show("You must enter minimum price before filtering!");
                return;
            }

            if (!string.IsNullOrEmpty(textBox_PriceMin.Text) && string.IsNullOrEmpty(textBox_PriceMax.Text))
            {
                MessageBox.Show("You must enter maximum price before filtering!");
                return;
            }

            if (!string.IsNullOrEmpty(textBox_YearMin.Text) && string.IsNullOrEmpty(textBox_YearMax.Text))
            {
                MessageBox.Show("You must enter maximum year before filtering!");
                return;
            }

            if (string.IsNullOrEmpty(textBox_YearMin.Text) && !string.IsNullOrEmpty(textBox_YearMax.Text))
            {
                MessageBox.Show("You must enter minimum year before filtering!");
                return;
            }

            string priceMin = textBox_PriceMin.Text;
            string priceMax = textBox_PriceMax.Text;
            string yearMin = textBox_YearMin.Text;
            string yearMax = textBox_YearMax.Text;
            string brand = textBox_Brand.Text;
            List<AutoAd> tempList = new List<AutoAd>();
            //I am not proud of this : )

            //Price Filter
            if (!string.IsNullOrEmpty(priceMin) && !string.IsNullOrEmpty(priceMax) &&
                string.IsNullOrEmpty(yearMin) && string.IsNullOrEmpty(yearMax) &&
                string.IsNullOrEmpty(brand)
              )
            {
                tempList = AutoAdList.PriceFilter(double.Parse(priceMin), double.Parse(priceMax));
            }

            //Year Filter
            if (string.IsNullOrEmpty(priceMin) && string.IsNullOrEmpty(priceMax) &&
                !string.IsNullOrEmpty(yearMin) && !string.IsNullOrEmpty(yearMax) &&
                string.IsNullOrEmpty(brand)
              )
            {
                tempList = AutoAdList.YearFilter(int.Parse(yearMin), int.Parse(yearMax));
            }

            //Brand Filter
            if (string.IsNullOrEmpty(priceMin) && string.IsNullOrEmpty(priceMax) &&
                string.IsNullOrEmpty(yearMin) && string.IsNullOrEmpty(yearMax) &&
                !string.IsNullOrEmpty(brand)
              )
            {
                tempList = AutoAdList.BrandFilter(brand);
            }


            //Price and Year Filter
            if (!string.IsNullOrEmpty(priceMin) && !string.IsNullOrEmpty(priceMax) &&
                !string.IsNullOrEmpty(yearMin) && !string.IsNullOrEmpty(yearMax) &&
                string.IsNullOrEmpty(brand)
              )
            {
                tempList = AutoAdList.PriceYearFilter(double.Parse(priceMin), double.Parse(priceMax), int.Parse(yearMin), int.Parse(yearMax));
            }

            //Price and Brand Filter
            if (!string.IsNullOrEmpty(priceMin) && !string.IsNullOrEmpty(priceMax) &&
               string.IsNullOrEmpty(yearMin) && string.IsNullOrEmpty(yearMax) &&
               !string.IsNullOrEmpty(brand)
             )
            {
                tempList = AutoAdList.PriceBrandFilter(double.Parse(priceMin), double.Parse(priceMax), brand);
            }

            //Year and Brand Filter
            if (string.IsNullOrEmpty(priceMin) && string.IsNullOrEmpty(priceMax) &&
               !string.IsNullOrEmpty(yearMin) && !string.IsNullOrEmpty(yearMax) &&
               !string.IsNullOrEmpty(brand)
             )
            {
                tempList = AutoAdList.YearBrandFilter(int.Parse(yearMin), int.Parse(yearMax), brand);
            }

            //Price, Year and Brand Filter
            if (!string.IsNullOrEmpty(priceMin) && !string.IsNullOrEmpty(priceMax) &&
                !string.IsNullOrEmpty(yearMin) && !string.IsNullOrEmpty(yearMax) &&
                !string.IsNullOrEmpty(brand)
              )
            {
                tempList = AutoAdList.PriceYearBrandFilter(double.Parse(priceMin), double.Parse(priceMax), int.Parse(yearMin), int.Parse(yearMax), brand);
            }

            if (string.IsNullOrEmpty(priceMin) && string.IsNullOrEmpty(priceMax) &&
                string.IsNullOrEmpty(yearMin) && string.IsNullOrEmpty(yearMax) &&
                string.IsNullOrEmpty(brand)
              )
            {
                MessageBox.Show("You have to use atleast one criteria for filtering!");
                return;
            }

            var bindigList = new BindingList<AutoAd>(tempList);
            dataGridView1.DataSource = new BindingSource(bindigList, null);
        }

        //This method opens adview-page
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form3 f3 = new Form3();
            DataGridView dgv = sender as DataGridView;
            string id = "";
           
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                f3.label_Ad.Text =dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); ;
                f3.label_AdType.Text = "TYPE: " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string brandAndModel = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + " " + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                f3.label_Brand.Text = brandAndModel;
                f3.modelForEdit = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                f3.label_Price.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() + "\u20AC"; //euro symbol
                f3.label_Year.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                f3.label_Fuel.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                f3.richTextBox_desc.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                f3.indexPic = 0;
                dataGridView1.Visible = false;
                panel1.Visible = false;
                openChildForm(f3);  // open adview-page
            }
            Global.globalId = id;  
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



namespace AutoAdUI
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_sortBy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_SortBy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_PriceMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_YearMax = new System.Windows.Forms.TextBox();
            this.textBox_PriceMax = new System.Windows.Forms.TextBox();
            this.textBox_Brand = new System.Windows.Forms.TextBox();
            this.button_Filter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_YearMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelChildForm.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.panel1);
            this.panelChildForm.Controls.Add(this.dataGridView1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(882, 653);
            this.panelChildForm.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_sortBy);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox_SortBy);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_PriceMin);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_YearMax);
            this.panel1.Controls.Add(this.textBox_PriceMax);
            this.panel1.Controls.Add(this.textBox_Brand);
            this.panel1.Controls.Add(this.button_Filter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_YearMin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 47);
            this.panel1.TabIndex = 30;
            // 
            // button_sortBy
            // 
            this.button_sortBy.BackColor = System.Drawing.Color.White;
            this.button_sortBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sortBy.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sortBy.ForeColor = System.Drawing.Color.Black;
            this.button_sortBy.Location = new System.Drawing.Point(488, -4);
            this.button_sortBy.Name = "button_sortBy";
            this.button_sortBy.Size = new System.Drawing.Size(87, 51);
            this.button_sortBy.TabIndex = 18;
            this.button_sortBy.Text = "Sort by:";
            this.button_sortBy.UseVisualStyleBackColor = false;
            this.button_sortBy.Click += new System.EventHandler(this.button_sortBy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(400, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Brand:";
            // 
            // comboBox_SortBy
            // 
            this.comboBox_SortBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox_SortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SortBy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_SortBy.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SortBy.ForeColor = System.Drawing.Color.Black;
            this.comboBox_SortBy.FormattingEnabled = true;
            this.comboBox_SortBy.Location = new System.Drawing.Point(581, 7);
            this.comboBox_SortBy.Name = "comboBox_SortBy";
            this.comboBox_SortBy.Size = new System.Drawing.Size(290, 26);
            this.comboBox_SortBy.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(231, -4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 50);
            this.label4.TabIndex = 28;
            this.label4.Text = "label4";
            // 
            // textBox_PriceMin
            // 
            this.textBox_PriceMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_PriceMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_PriceMin.ForeColor = System.Drawing.Color.Black;
            this.textBox_PriceMin.Location = new System.Drawing.Point(98, 16);
            this.textBox_PriceMin.Name = "textBox_PriceMin";
            this.textBox_PriceMin.Size = new System.Drawing.Size(56, 15);
            this.textBox_PriceMin.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(365, -6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1, 50);
            this.label6.TabIndex = 29;
            this.label6.Text = "label6";
            // 
            // textBox_YearMax
            // 
            this.textBox_YearMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_YearMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_YearMax.ForeColor = System.Drawing.Color.Black;
            this.textBox_YearMax.Location = new System.Drawing.Point(300, 16);
            this.textBox_YearMax.Name = "textBox_YearMax";
            this.textBox_YearMax.Size = new System.Drawing.Size(56, 15);
            this.textBox_YearMax.TabIndex = 25;
            // 
            // textBox_PriceMax
            // 
            this.textBox_PriceMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_PriceMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_PriceMax.ForeColor = System.Drawing.Color.Black;
            this.textBox_PriceMax.Location = new System.Drawing.Point(160, 16);
            this.textBox_PriceMax.Name = "textBox_PriceMax";
            this.textBox_PriceMax.Size = new System.Drawing.Size(56, 15);
            this.textBox_PriceMax.TabIndex = 20;
            // 
            // textBox_Brand
            // 
            this.textBox_Brand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_Brand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Brand.ForeColor = System.Drawing.Color.Black;
            this.textBox_Brand.Location = new System.Drawing.Point(376, 16);
            this.textBox_Brand.Name = "textBox_Brand";
            this.textBox_Brand.Size = new System.Drawing.Size(106, 15);
            this.textBox_Brand.TabIndex = 27;
            // 
            // button_Filter
            // 
            this.button_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Filter.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Filter.ForeColor = System.Drawing.Color.Black;
            this.button_Filter.Location = new System.Drawing.Point(-1, -4);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(87, 51);
            this.button_Filter.TabIndex = 19;
            this.button_Filter.Text = "Filter:";
            this.button_Filter.UseVisualStyleBackColor = true;
            this.button_Filter.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(275, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Year:";
            // 
            // textBox_YearMin
            // 
            this.textBox_YearMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_YearMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_YearMin.ForeColor = System.Drawing.Color.Black;
            this.textBox_YearMin.Location = new System.Drawing.Point(238, 16);
            this.textBox_YearMin.Name = "textBox_YearMin";
            this.textBox_YearMin.Size = new System.Drawing.Size(56, 15);
            this.textBox_YearMin.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(129, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Price:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 20;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(882, 615);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.panelChildForm);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panelChildForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_sortBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_SortBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_PriceMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_YearMax;
        private System.Windows.Forms.TextBox textBox_PriceMax;
        private System.Windows.Forms.TextBox textBox_Brand;
        private System.Windows.Forms.Button button_Filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_YearMin;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}
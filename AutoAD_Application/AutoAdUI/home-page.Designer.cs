
namespace AutoAdUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.panelAds = new System.Windows.Forms.Panel();
            this.buttonAds = new System.Windows.Forms.Button();
            this.panelAdSub = new System.Windows.Forms.Panel();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.panelAd = new System.Windows.Forms.Panel();
            this.buttonAd = new System.Windows.Forms.Button();
            this.pictureBox_smallLogo = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label_shortDescription = new System.Windows.Forms.Label();
            this.pictureBox_bigLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelAds.SuspendLayout();
            this.panelAdSub.SuspendLayout();
            this.panelAd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_smallLogo)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bigLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.panelInfo);
            this.panelMenu.Controls.Add(this.panelAds);
            this.panelMenu.Controls.Add(this.panelAdSub);
            this.panelMenu.Controls.Add(this.panelAd);
            this.panelMenu.Controls.Add(this.pictureBox_smallLogo);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Name = "panelMenu";
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.buttonAbout);
            this.panelInfo.Controls.Add(this.buttonInfo);
            resources.ApplyResources(this.panelInfo, "panelInfo");
            this.panelInfo.Name = "panelInfo";
            // 
            // buttonAbout
            // 
            resources.ApplyResources(this.buttonAbout, "buttonAbout");
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonInfo, "buttonInfo");
            this.buttonInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.UseVisualStyleBackColor = true;
            // 
            // panelAds
            // 
            this.panelAds.Controls.Add(this.buttonAds);
            resources.ApplyResources(this.panelAds, "panelAds");
            this.panelAds.Name = "panelAds";
            // 
            // buttonAds
            // 
            resources.ApplyResources(this.buttonAds, "buttonAds");
            this.buttonAds.FlatAppearance.BorderSize = 0;
            this.buttonAds.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAds.Name = "buttonAds";
            this.buttonAds.UseVisualStyleBackColor = true;
            this.buttonAds.Click += new System.EventHandler(this.buttonAds_Click);
            // 
            // panelAdSub
            // 
            this.panelAdSub.BackColor = System.Drawing.Color.Gainsboro;
            this.panelAdSub.Controls.Add(this.buttonAdauga);
            resources.ApplyResources(this.panelAdSub, "panelAdSub");
            this.panelAdSub.Name = "panelAdSub";
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.buttonAdauga, "buttonAdauga");
            this.buttonAdauga.FlatAppearance.BorderSize = 0;
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.UseVisualStyleBackColor = false;
            this.buttonAdauga.Click += new System.EventHandler(this.button_createAd_Click);
            // 
            // panelAd
            // 
            this.panelAd.Controls.Add(this.buttonAd);
            resources.ApplyResources(this.panelAd, "panelAd");
            this.panelAd.Name = "panelAd";
            // 
            // buttonAd
            // 
            resources.ApplyResources(this.buttonAd, "buttonAd");
            this.buttonAd.FlatAppearance.BorderSize = 0;
            this.buttonAd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAd.Name = "buttonAd";
            this.buttonAd.UseVisualStyleBackColor = true;
            this.buttonAd.Click += new System.EventHandler(this.buttonAd_Click);
            // 
            // pictureBox_smallLogo
            // 
            resources.ApplyResources(this.pictureBox_smallLogo, "pictureBox_smallLogo");
            this.pictureBox_smallLogo.Name = "pictureBox_smallLogo";
            this.pictureBox_smallLogo.TabStop = false;
            // 
            // panelLogo
            // 
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Name = "panelLogo";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panelChildForm.Controls.Add(this.label_shortDescription);
            this.panelChildForm.Controls.Add(this.pictureBox_bigLogo);
            resources.ApplyResources(this.panelChildForm, "panelChildForm");
            this.panelChildForm.Name = "panelChildForm";
            // 
            // label_shortDescription
            // 
            resources.ApplyResources(this.label_shortDescription, "label_shortDescription");
            this.label_shortDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_shortDescription.Name = "label_shortDescription";
            // 
            // pictureBox_bigLogo
            // 
            this.pictureBox_bigLogo.Image = global::AutoAdUI.Properties.Resources.big_logo;
            resources.ApplyResources(this.pictureBox_bigLogo, "pictureBox_bigLogo");
            this.pictureBox_bigLogo.Name = "pictureBox_bigLogo";
            this.pictureBox_bigLogo.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelAds.ResumeLayout(false);
            this.panelAdSub.ResumeLayout(false);
            this.panelAd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_smallLogo)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bigLogo)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox_smallLogo;
        private System.Windows.Forms.Panel panelAd;
        private System.Windows.Forms.Panel panelAdSub;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Button buttonAd;
        private System.Windows.Forms.Panel panelAds;
        private System.Windows.Forms.Button buttonAds;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonAbout;
        public System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox_bigLogo;
        private System.Windows.Forms.Label label_shortDescription;
    }
}


namespace TermProjectDB
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.rideshareTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.browseScheduleForm = new System.Windows.Forms.Button();
            this.scheduleForm = new System.Windows.Forms.Button();
            this.driverForm = new System.Windows.Forms.Button();
            this.riderForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitApp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rideshareTitle
            // 
            this.rideshareTitle.AutoSize = true;
            this.rideshareTitle.Font = new System.Drawing.Font("Papyrus", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rideshareTitle.Location = new System.Drawing.Point(155, 22);
            this.rideshareTitle.Name = "rideshareTitle";
            this.rideshareTitle.Size = new System.Drawing.Size(299, 79);
            this.rideshareTitle.TabIndex = 0;
            this.rideshareTitle.Text = "CarpetRide";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "A whole new world of ride-sharing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Term Project Database / Ride-Request App";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "(c) 2018, Christian Rhodes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.browseScheduleForm);
            this.panel1.Controls.Add(this.scheduleForm);
            this.panel1.Controls.Add(this.driverForm);
            this.panel1.Controls.Add(this.riderForm);
            this.panel1.Location = new System.Drawing.Point(31, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 169);
            this.panel1.TabIndex = 4;
            // 
            // browseScheduleForm
            // 
            this.browseScheduleForm.Location = new System.Drawing.Point(287, 82);
            this.browseScheduleForm.Name = "browseScheduleForm";
            this.browseScheduleForm.Size = new System.Drawing.Size(147, 41);
            this.browseScheduleForm.TabIndex = 3;
            this.browseScheduleForm.Text = "Browse Schedule";
            this.browseScheduleForm.UseVisualStyleBackColor = true;
            this.browseScheduleForm.Click += new System.EventHandler(this.browseScheduleForm_Click);
            // 
            // scheduleForm
            // 
            this.scheduleForm.Location = new System.Drawing.Point(287, 18);
            this.scheduleForm.Name = "scheduleForm";
            this.scheduleForm.Size = new System.Drawing.Size(147, 41);
            this.scheduleForm.TabIndex = 2;
            this.scheduleForm.Text = "Schedule";
            this.scheduleForm.UseVisualStyleBackColor = true;
            this.scheduleForm.Click += new System.EventHandler(this.scheduleForm_Click);
            // 
            // driverForm
            // 
            this.driverForm.Location = new System.Drawing.Point(68, 82);
            this.driverForm.Name = "driverForm";
            this.driverForm.Size = new System.Drawing.Size(147, 41);
            this.driverForm.TabIndex = 1;
            this.driverForm.Text = "Driver";
            this.driverForm.UseVisualStyleBackColor = true;
            this.driverForm.Click += new System.EventHandler(this.driverForm_Click);
            // 
            // riderForm
            // 
            this.riderForm.Location = new System.Drawing.Point(68, 18);
            this.riderForm.Name = "riderForm";
            this.riderForm.Size = new System.Drawing.Size(147, 41);
            this.riderForm.TabIndex = 0;
            this.riderForm.Text = "Rider";
            this.riderForm.UseVisualStyleBackColor = true;
            this.riderForm.Click += new System.EventHandler(this.riderForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(503, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // exitApp
            // 
            this.exitApp.Location = new System.Drawing.Point(169, 325);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(212, 47);
            this.exitApp.TabIndex = 6;
            this.exitApp.Text = "Exit";
            this.exitApp.UseVisualStyleBackColor = true;
            this.exitApp.Click += new System.EventHandler(this.exitApp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 384);
            this.Controls.Add(this.exitApp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rideshareTitle);
            this.Name = "frmMain";
            this.Text = "CarpetRide Main Menu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rideshareTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button browseScheduleForm;
        private System.Windows.Forms.Button scheduleForm;
        private System.Windows.Forms.Button driverForm;
        private System.Windows.Forms.Button riderForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitApp;
    }
}


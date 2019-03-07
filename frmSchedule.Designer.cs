namespace TermProjectDB
{
    partial class frmSchedule
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
            this.label1 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_streetaddress = new System.Windows.Forms.Label();
            this.txt_destination = new System.Windows.Forms.TextBox();
            this.lb_destination = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_UserPrompt_Location = new System.Windows.Forms.Label();
            this.txt_StreetAddress = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schedule";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(468, 231);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 28);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Set up a Ride";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_streetaddress);
            this.groupBox1.Controls.Add(this.lb_UserPrompt_Location);
            this.groupBox1.Controls.Add(this.txt_destination);
            this.groupBox1.Controls.Add(this.lb_destination);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_StreetAddress);
            this.groupBox1.Location = new System.Drawing.Point(16, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(705, 168);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a Ride Request";
            // 
            // lb_streetaddress
            // 
            this.lb_streetaddress.AutoSize = true;
            this.lb_streetaddress.Location = new System.Drawing.Point(65, 56);
            this.lb_streetaddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_streetaddress.Name = "lb_streetaddress";
            this.lb_streetaddress.Size = new System.Drawing.Size(102, 17);
            this.lb_streetaddress.TabIndex = 18;
            this.lb_streetaddress.Text = "Street Address";
            // 
            // txt_destination
            // 
            this.txt_destination.Location = new System.Drawing.Point(277, 117);
            this.txt_destination.Margin = new System.Windows.Forms.Padding(4);
            this.txt_destination.Name = "txt_destination";
            this.txt_destination.Size = new System.Drawing.Size(275, 22);
            this.txt_destination.TabIndex = 23;
            // 
            // lb_destination
            // 
            this.lb_destination.AutoSize = true;
            this.lb_destination.Location = new System.Drawing.Point(65, 120);
            this.lb_destination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_destination.Name = "lb_destination";
            this.lb_destination.Size = new System.Drawing.Size(187, 17);
            this.lb_destination.TabIndex = 22;
            this.lb_destination.Text = "Destination (Street Address)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Please enter your Desired Arrival time and Destination";
            // 
            // lb_UserPrompt_Location
            // 
            this.lb_UserPrompt_Location.AutoSize = true;
            this.lb_UserPrompt_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserPrompt_Location.Location = new System.Drawing.Point(60, 19);
            this.lb_UserPrompt_Location.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_UserPrompt_Location.Name = "lb_UserPrompt_Location";
            this.lb_UserPrompt_Location.Size = new System.Drawing.Size(232, 24);
            this.lb_UserPrompt_Location.TabIndex = 20;
            this.lb_UserPrompt_Location.Text = "Please enter your location.";
            // 
            // txt_StreetAddress
            // 
            this.txt_StreetAddress.Location = new System.Drawing.Point(175, 52);
            this.txt_StreetAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StreetAddress.Name = "txt_StreetAddress";
            this.txt_StreetAddress.Size = new System.Drawing.Size(275, 22);
            this.txt_StreetAddress.TabIndex = 19;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 287);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSchedule";
            this.Text = "frmSchedule";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_streetaddress;
        private System.Windows.Forms.Label lb_UserPrompt_Location;
        private System.Windows.Forms.TextBox txt_destination;
        private System.Windows.Forms.Label lb_destination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_StreetAddress;
    }
}
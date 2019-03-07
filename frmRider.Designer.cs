namespace TermProjectDB
{
    partial class frmRider
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.riderPhone = new System.Windows.Forms.TextBox();
            this.riderZipCode = new System.Windows.Forms.TextBox();
            this.riderState = new System.Windows.Forms.TextBox();
            this.riderCity = new System.Windows.Forms.TextBox();
            this.riderEmailAddress = new System.Windows.Forms.TextBox();
            this.riderStreetAddress = new System.Windows.Forms.TextBox();
            this.riderLastName = new System.Windows.Forms.TextBox();
            this.riderFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.insertRider = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.paymentType = new System.Windows.Forms.ListBox();
            this.termProjectDBDataSet = new TermProjectDB.TermProjectDBDataSet();
            this.termProjectDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.termProjectDBDataSet1 = new TermProjectDB.TermProjectDBDataSet1();
            this.paymentMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentMethodTableAdapter = new TermProjectDB.TermProjectDBDataSet1TableAdapters.PaymentMethodTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termProjectDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termProjectDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termProjectDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.paymentType);
            this.groupBox1.Controls.Add(this.riderPhone);
            this.groupBox1.Controls.Add(this.riderZipCode);
            this.groupBox1.Controls.Add(this.riderState);
            this.groupBox1.Controls.Add(this.riderCity);
            this.groupBox1.Controls.Add(this.riderEmailAddress);
            this.groupBox1.Controls.Add(this.riderStreetAddress);
            this.groupBox1.Controls.Add(this.riderLastName);
            this.groupBox1.Controls.Add(this.riderFirstName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(751, 481);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INSERT RIDER INFORMATION";
            // 
            // riderPhone
            // 
            this.riderPhone.Location = new System.Drawing.Point(115, 434);
            this.riderPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.riderPhone.Name = "riderPhone";
            this.riderPhone.Size = new System.Drawing.Size(176, 27);
            this.riderPhone.TabIndex = 15;
            // 
            // riderZipCode
            // 
            this.riderZipCode.Location = new System.Drawing.Point(148, 379);
            this.riderZipCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.riderZipCode.Name = "riderZipCode";
            this.riderZipCode.Size = new System.Drawing.Size(111, 27);
            this.riderZipCode.TabIndex = 14;
            // 
            // riderState
            // 
            this.riderState.Location = new System.Drawing.Point(112, 321);
            this.riderState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.riderState.Name = "riderState";
            this.riderState.Size = new System.Drawing.Size(75, 27);
            this.riderState.TabIndex = 13;
            // 
            // riderCity
            // 
            this.riderCity.Location = new System.Drawing.Point(101, 260);
            this.riderCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.riderCity.Name = "riderCity";
            this.riderCity.Size = new System.Drawing.Size(281, 27);
            this.riderCity.TabIndex = 12;
            // 
            // riderEmailAddress
            // 
            this.riderEmailAddress.Location = new System.Drawing.Point(195, 206);
            this.riderEmailAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.riderEmailAddress.Name = "riderEmailAddress";
            this.riderEmailAddress.Size = new System.Drawing.Size(417, 27);
            this.riderEmailAddress.TabIndex = 11;
            // 
            // riderStreetAddress
            // 
            this.riderStreetAddress.Location = new System.Drawing.Point(195, 140);
            this.riderStreetAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.riderStreetAddress.Name = "riderStreetAddress";
            this.riderStreetAddress.Size = new System.Drawing.Size(417, 27);
            this.riderStreetAddress.TabIndex = 10;
            // 
            // riderLastName
            // 
            this.riderLastName.Location = new System.Drawing.Point(159, 82);
            this.riderLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.riderLastName.Name = "riderLastName";
            this.riderLastName.Size = new System.Drawing.Size(281, 27);
            this.riderLastName.TabIndex = 9;
            // 
            // riderFirstName
            // 
            this.riderFirstName.Location = new System.Drawing.Point(159, 33);
            this.riderFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.riderFirstName.Name = "riderFirstName";
            this.riderFirstName.Size = new System.Drawing.Size(281, 27);
            this.riderFirstName.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Papyrus", 10.8F);
            this.label8.Location = new System.Drawing.Point(43, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 30);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Papyrus", 10.8F);
            this.label7.Location = new System.Drawing.Point(43, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Papyrus", 10.8F);
            this.label6.Location = new System.Drawing.Point(43, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Papyrus", 10.8F);
            this.label5.Location = new System.Drawing.Point(43, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Papyrus", 10.8F);
            this.label4.Location = new System.Drawing.Point(43, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 10.8F);
            this.label3.Location = new System.Drawing.Point(43, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Street Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // insertRider
            // 
            this.insertRider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertRider.Location = new System.Drawing.Point(127, 508);
            this.insertRider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertRider.Name = "insertRider";
            this.insertRider.Size = new System.Drawing.Size(179, 48);
            this.insertRider.TabIndex = 1;
            this.insertRider.Text = "Insert A Rider";
            this.insertRider.UseVisualStyleBackColor = true;
            this.insertRider.Click += new System.EventHandler(this.insertRider_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(444, 508);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(179, 48);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // paymentType
            // 
            this.paymentType.DataSource = this.paymentMethodBindingSource;
            this.paymentType.DisplayMember = "PmntType";
            this.paymentType.FormattingEnabled = true;
            this.paymentType.ItemHeight = 21;
            this.paymentType.Location = new System.Drawing.Point(444, 338);
            this.paymentType.Name = "paymentType";
            this.paymentType.Size = new System.Drawing.Size(263, 130);
            this.paymentType.TabIndex = 16;
            this.paymentType.ValueMember = "PmntType";
            // 
            // termProjectDBDataSet
            // 
            this.termProjectDBDataSet.DataSetName = "TermProjectDBDataSet";
            this.termProjectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // termProjectDBDataSetBindingSource
            // 
            this.termProjectDBDataSetBindingSource.DataSource = this.termProjectDBDataSet;
            this.termProjectDBDataSetBindingSource.Position = 0;
            // 
            // termProjectDBDataSet1
            // 
            this.termProjectDBDataSet1.DataSetName = "TermProjectDBDataSet1";
            this.termProjectDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentMethodBindingSource
            // 
            this.paymentMethodBindingSource.DataMember = "PaymentMethod";
            this.paymentMethodBindingSource.DataSource = this.termProjectDBDataSet1;
            // 
            // paymentMethodTableAdapter
            // 
            this.paymentMethodTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Papyrus", 10.8F);
            this.label9.Location = new System.Drawing.Point(448, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 30);
            this.label9.TabIndex = 17;
            this.label9.Text = "Payment Method";
            // 
            // frmRider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(777, 582);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.insertRider);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRider";
            this.Text = "frmRider";
            this.Load += new System.EventHandler(this.frmRider_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termProjectDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termProjectDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termProjectDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox riderPhone;
        private System.Windows.Forms.TextBox riderZipCode;
        private System.Windows.Forms.TextBox riderState;
        private System.Windows.Forms.TextBox riderCity;
        private System.Windows.Forms.TextBox riderEmailAddress;
        private System.Windows.Forms.TextBox riderStreetAddress;
        private System.Windows.Forms.TextBox riderLastName;
        private System.Windows.Forms.TextBox riderFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insertRider;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ListBox paymentType;
        private System.Windows.Forms.BindingSource termProjectDBDataSetBindingSource;
        private TermProjectDBDataSet termProjectDBDataSet;
        private TermProjectDBDataSet1 termProjectDBDataSet1;
        private System.Windows.Forms.BindingSource paymentMethodBindingSource;
        private TermProjectDBDataSet1TableAdapters.PaymentMethodTableAdapter paymentMethodTableAdapter;
        private System.Windows.Forms.Label label9;
    }
}
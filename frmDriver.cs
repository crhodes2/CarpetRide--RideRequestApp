using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TermProjectDB
{
    public partial class frmDriver : Form
    {
        private MessageBox strMessageBoxTitle;
        public frmDriver()
        {
            InitializeComponent();
        }


        //------------------------------------------------------------- CANCEL FORM ----------------------------------------------
        private void cancel_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmMain mainForm = new frmMain();
            Close();
            mainForm.Show();

            Cursor.Current = Cursors.Default;
        }


        //------------------------------------------------------------- CREATE A DRIVER ----------------------------------------------

        private void insertDriver_Click(object sender, EventArgs e)
        {
            if (driverFirstName.Text == "" || driverFirstName.Text == String.Empty || driverFirstName.TextLength == 0)
            {
                MessageBox.Show("Please enter First Name","Incomplete Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (driverLastName.Text == "" || driverLastName.Text == String.Empty || driverLastName.TextLength == 0)
            {
                MessageBox.Show("Please enter Last Name", "Incomplete Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (driverStreetAddress.Text == "" || driverStreetAddress.Text == String.Empty || driverStreetAddress.TextLength == 0)
            {
                MessageBox.Show("Please enter Street Address", "Incomplete Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (driverEmailAddress.Text == "" || driverEmailAddress.Text == String.Empty || driverEmailAddress.TextLength == 0)
            {
                MessageBox.Show("Please enter Email Address", "Incomplete Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (driverCity.Text == "" || driverCity.Text == String.Empty || driverCity.TextLength == 0)
            {
                MessageBox.Show("Please enter City Name", "Incomplete Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (driverState.Text == "" || driverState.Text == String.Empty || driverState.TextLength == 0)
            {
                MessageBox.Show("Please enter State Name", "Incomplete Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (driverZipCode.Text == "" || driverZipCode.Text == String.Empty || driverZipCode.TextLength == 0)
            {
                MessageBox.Show("Please enter Zip Code", "Incomplete Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (driverPhone.Text == "" || driverPhone.Text == String.Empty || driverPhone.TextLength == 0)
            {
                MessageBox.Show("Please enter Phone number", "Incomplete Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            string FirstName = driverFirstName.Text.Trim();
            string LastName = driverLastName.Text.Trim();
            string StreetAddress = driverStreetAddress.Text.Trim();
            string EmailAddress = driverEmailAddress.Text.Trim();
            string City = driverCity.Text.Trim();
            string State = driverState.Text.Trim();
            string ZipCode = driverZipCode.Text.Trim();
            string Phone = driverPhone.Text.Trim(); ;

            string connectionString = null;

            connectionString = ConfigurationManager.ConnectionStrings["TermProjectDB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.[sp_InsertDriver]", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@First_Name", SqlDbType.NVarChar, 255).Value = FirstName;
                    cmd.Parameters.Add("@Last_Name", SqlDbType.NVarChar, 255).Value = LastName;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 255).Value = StreetAddress;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 255).Value = EmailAddress;
                    cmd.Parameters.Add("@City", SqlDbType.NVarChar, 255).Value = City;
                    cmd.Parameters.Add("@State", SqlDbType.NVarChar, 255).Value = State;
                    cmd.Parameters.Add("@ZipCode", SqlDbType.NVarChar, 255).Value = ZipCode;
                    cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 255).Value = Phone;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Driver " + FirstName + " " + LastName + " has been added successfully!", "Success!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            cancel_Click(sender, e);

        }

    }
}

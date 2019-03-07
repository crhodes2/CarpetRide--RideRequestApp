using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TermProjectDB
{
    public partial class frmRider : Form
    {

        public frmRider()
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


        //------------------------------------------------------------- CREATE A RIDER ----------------------------------------------

        private void insertRider_Click(object sender, EventArgs e)
        {
            if (riderFirstName.Text == "" || riderFirstName.Text == String.Empty || riderFirstName.TextLength == 0)
            {
                MessageBox.Show("Please enter First Name", "Incomplete Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (riderLastName.Text == "" || riderLastName.Text == String.Empty || riderLastName.TextLength == 0)
            {
                MessageBox.Show("Please enter Last Name", "Incomplete Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (riderStreetAddress.Text == "" || riderStreetAddress.Text == String.Empty || riderStreetAddress.TextLength == 0)
            {
                MessageBox.Show("Please enter Street Address", "Incomplete Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (riderEmailAddress.Text == "" || riderEmailAddress.Text == String.Empty || riderEmailAddress.TextLength == 0)
            {
                MessageBox.Show("Please enter Email Address", "Incomplete Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (riderCity.Text == "" || riderCity.Text == String.Empty || riderCity.TextLength == 0)
            {
                MessageBox.Show("Please enter City Name", "Incomplete Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (riderState.Text == "" || riderState.Text == String.Empty || riderState.TextLength == 0)
            {
                MessageBox.Show("Please enter State Name", "Incomplete Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (riderZipCode.Text == "" || riderZipCode.Text == String.Empty || riderZipCode.TextLength == 0)
            {
                MessageBox.Show("Please enter Zip Code", "Incomplete Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (riderPhone.Text == "" || riderPhone.Text == String.Empty || riderPhone.TextLength == 0)
            {
                MessageBox.Show("Please enter Phone number", "Incomplete Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            string FirstName = riderFirstName.Text.Trim();
            string LastName = riderLastName.Text.Trim();
            string StreetAddress = riderStreetAddress.Text.Trim();
            string EmailAddress = riderEmailAddress.Text.Trim();
            string City = riderCity.Text.Trim();
            string State = riderState.Text.Trim();
            string ZipCode = riderZipCode.Text.Trim();
            string Phone = riderPhone.Text.Trim();
            int PaymentID = 0;
            
            switch (paymentType.SelectedValue)
            {
                case "Check": 
                    PaymentID = 2;
                    break;
                case "Credit Card": 
                    PaymentID = 3;
                    break;
                case "Debit Card": 
                    PaymentID = 4;
                    break;
                case "PayPal": 
                    PaymentID = 5;
                    break;
                default:
                    PaymentID = 1;
                    break;
            }

            string connectionString = null;

            connectionString = ConfigurationManager.ConnectionStrings["TermProjectDB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.[sp_InsertRider]", con))
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
                    cmd.Parameters.Add("@PaymentId", SqlDbType.Int).Value = PaymentID;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Rider " + FirstName + " " + LastName + " has been added successfully!", "Success!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            cancel_Click(sender, e);
        }

        private void frmRider_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'termProjectDBDataSet1.PaymentMethod' table. You can move, or remove it, as needed.
            this.paymentMethodTableAdapter.Fill(this.termProjectDBDataSet1.PaymentMethod);

        }
    }
}

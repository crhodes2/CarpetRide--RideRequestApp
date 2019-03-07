using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProjectDB
{

    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        //------------------------------ EXIT APPLICATION ------------>
        private void exitApp_Click(object sender, EventArgs e)
        {
            Close();
        }

        //------------------------------ RIDER FORM ------------------------->
        private void riderForm_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmRider RiderForm = new frmRider();
            Hide();
            RiderForm.Show();

            Cursor.Current = Cursors.Default;

        }


        //------------------------------ DRIVER FORM ------------------------------->
        private void driverForm_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmDriver DriverForm = new frmDriver();
            Hide();
            DriverForm.Show();

            Cursor.Current = Cursors.Default;
        }


        //------------------------------ SCHEDULE FORM  ------------------------------------->
        private void scheduleForm_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmSchedule SchedForm= new frmSchedule();
            Hide();
            SchedForm.Show();

            Cursor.Current = Cursors.Default;
        }


        //------------------------------ BROWSE SCHEDULE FORM -------------------------------------->
        private void browseScheduleForm_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmBrowseSchedule BrowseForm = new frmBrowseSchedule();
            Hide();
            BrowseForm.Show();

            Cursor.Current = Cursors.Default;
        }
    }
}

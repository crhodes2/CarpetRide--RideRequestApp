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
    public partial class frmBrowseSchedule : Form
    {
        public frmBrowseSchedule()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmMain mainForm = new frmMain();
            Close();
            mainForm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void frmBrowseSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'termProjectDBDataSet.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.termProjectDBDataSet.Schedule);

        }
    }
}

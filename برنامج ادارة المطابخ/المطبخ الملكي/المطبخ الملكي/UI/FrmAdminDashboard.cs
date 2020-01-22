using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using المطبخ_الملكي.UI;

namespace المطبخ_الملكي
{
    public partial class FrmAdminDashboard : Form
    {
        public FrmAdminDashboard()
        {
            InitializeComponent();
        }

        private void المستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsers user = new UI.FrmUsers();
            user.Show();
        }

        private void lblLoggedInUser_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using المطبخ_الملكي.BLL;
using المطبخ_الملكي.DAL;

namespace المطبخ_الملكي.UI
{
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }
        userBLL u = new userBLL();
        userDAl dal = new userDAl();


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            u.first_name = TxtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.username = txtusername.Text;
            u.password = txtPassword.Text;
            u.user_type = cmbUserType.Text;
            u.added_date = DateTime.Now;
            bool success = dal.insert(u);
            if (success == true)
            {
                MessageBox.Show("تمت اضافة الحساب بنجاح");
                clear();
            }
            else
            {
                MessageBox.Show(" خطاء في الاضافة");
            }
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }




        private void FrmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

        }

        private void clear()
        {
            txtid.Text = "";
            TxtFirstName.Text = "";
            txtLastName.Text = "";
            txtusername.Text = "";
            txtPassword.Text = "";
            cmbUserType.Text = "";

        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtid.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            TxtFirstName.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtusername.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            cmbUserType.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(txtid.Text);
            u.first_name = TxtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.username = txtusername.Text;
            u.password = txtPassword.Text;
            u.user_type = cmbUserType.Text;

            bool success = dal.update(u);

            if(success == true)
            {
                MessageBox.Show("تم التعديل بنجاح");
                clear();
            }
            else
            {
                MessageBox.Show("فشل التعديل ! ");

            }
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(txtid.Text);
            bool success = dal.Delete(u);
            if (success == true)
            {
                MessageBox.Show("تم الحذف بنجاح ");
                clear();
            }
            else
            {
                MessageBox.Show("! فشلت العمليه ");
            }
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }
    }
}

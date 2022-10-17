using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTracking
{
    public partial class FrmDepartmentList : Form
    {
        public FrmDepartmentList()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FrmDepartment frm = new FrmDepartment();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            ShowList();
        }

        private void FrmDepartmentList_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void ShowList()
        {
            List<DEPARTMENT> dList = new List<DEPARTMENT>();
            dList = DepartmentBLL.GetDepartments();
            dataGridView1.DataSource = dList;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using BLL;
using DAL.DAO;
using DAL.DTO;
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
    public partial class FrmEmployeeList : Form
    {
        EmployeeDTO dto = new EmployeeDTO();
        bool comboFull = false;
        public FrmEmployeeList()
        {
            InitializeComponent();
        }

        private void TxtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.IsNumber(e);
        }

        private void TxtBoxUserNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FrmEmployee frm = new FrmEmployee();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            FrmEmployee frm = new FrmEmployee();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEmployeeList_Load(object sender, EventArgs e)
        {
            dto = EmployeeBLL.GetAll();
            dataGridView1.DataSource = dto.Employees;
            comboFull = false;
            CmbDepartment.DataSource = dto.Departments;
            CmbDepartment.DisplayMember = "DepartmentName";
            CmbDepartment.ValueMember = "ID";
            CmbPosition.DataSource = dto.Positions;
            CmbPosition.DisplayMember = "PositionName";
            CmbPosition.ValueMember = "ID";
            CmbDepartment.SelectedIndex = -1;
            CmbPosition.SelectedIndex = -1;
            comboFull = true;
        }

        private void CmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboFull)
            {
                CmbPosition.DataSource = dto.Positions.Where(x => x.DepartmentID == 
                Convert.ToInt32(CmbDepartment.SelectedValue)).ToList();
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {

        }
    }
}

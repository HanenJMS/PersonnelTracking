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
            List<EmployeeDetailDTO> list = dto.Employees;
            if(TxtBoxUserNo.Text.Trim() != "")
            {
                list = list.Where(x => x.UserNo == Convert.ToInt32(TxtBoxUserNo.Text)).ToList();
            }
            if (TextBoxName.Text.Trim() != "")
            {
                list = list.Where(x => x.Name.Contains(TextBoxName.Text)).ToList();
            }
            if (TextBoxSurName.Text.Trim() != "")
            {
                list = list.Where(x => x.Name.Contains(TextBoxSurName.Text)).ToList();
            }
            if(CmbDepartment.SelectedIndex != -1)
            {
                list = list.Where(x => x.DepartmentID == Convert.ToInt32(CmbDepartment.SelectedValue)).ToList();
            }
            if (CmbPosition.SelectedIndex != -1)
            {
                list = list.Where(x => x.DepartmentID == Convert.ToInt32(CmbPosition.SelectedValue)).ToList();
            }
            dataGridView1.DataSource = list;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TxtBoxUserNo.Clear();
            TextBoxName.Clear();
            TextBoxSurName.Clear();
            comboFull = false;
            CmbDepartment.SelectedIndex = -1;
            CmbDepartment.DataSource = dto.Departments;
            CmbPosition.SelectedIndex = -1;
            CmbPosition.DataSource = dto.Positions;
            comboFull = true;
            dataGridView1.DataSource = dto.Employees;
        }
    }
}

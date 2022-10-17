using BLL;
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
    public partial class FrmEmployee : Form
    {
        EmployeeDTO dto = new EmployeeDTO();

        bool comboFull = false;
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.IsNumber(e);
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            
            dto = EmployeeBLL.GetAll();
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
                int departmentID = Convert.ToInt32(CmbDepartment.SelectedValue);
                CmbPosition.DataSource = dto.Positions.Where(x => x.DepartmentID == departmentID).ToList();
                MessageBox.Show(departmentID + "");
            }
        }

        private void ButtonBrowsw_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                TextBoxImagePath.Text = openFileDialog1.FileName;
            }
        }
    }
}

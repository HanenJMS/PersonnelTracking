using BLL;
using DAL;
using DAL.DAO;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTracking
{
    public partial class FrmEmployee : Form
    {
        EmployeeDTO dto = new EmployeeDTO();
        string fileName = "";

        bool comboFull = false;
        bool isUnique = false;
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
                string Unique = Guid.NewGuid().ToString();
                fileName += Unique + openFileDialog1.SafeFileName;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(TxtUserNo.Text.Trim()=="")
            {
                MessageBox.Show("User number field is Empty");
            }
            else if(IsUniqueNo())
            {
                MessageBox.Show("User Number is currently in use. Please change the number");
            }
            else if (TextBoxPassword.Text.Trim() == "")
            {
                MessageBox.Show("Password field is Empty");
            }
            else if (TextBoxName.Text.Trim() == "")
            {
                MessageBox.Show("Name field is Empty");
            }
            else if (TextBoxSurName.Text.Trim() == "")
            {
                MessageBox.Show("surname field is Empty");
            }
            else if (TextboxSalary.Text.Trim() == "")
            {
                MessageBox.Show("salary field is Empty");
            }
            else if(CmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Select department");
            }
            else if (CmbPosition.SelectedIndex == -1)
            {
                MessageBox.Show("Select position");
            }
            else
            {
                EMPLOYEE employee = new EMPLOYEE();
                employee.UserNo = Convert.ToInt32(TxtUserNo.Text);
                employee.Password = TextBoxPassword.Text;
                employee.isAdmin = ChAdmin.Checked;
                employee.Name = TextBoxName.Text;
                employee.Surname = TextBoxSurName.Text;
                employee.ImagePath = TextBoxImagePath.Text;
                employee.DepartmentID = Convert.ToInt32(CmbDepartment.SelectedValue);
                employee.PositionID = Convert.ToInt32(CmbPosition.SelectedValue);
                employee.Salary = Convert.ToInt32(TextboxSalary);
                employee.Birthday = dateTimePicker1.Value;
                employee.Address = textBox1.Text;
                EmployeeBLL.AddEmployee(employee);
                File.Copy(TextBoxImagePath.Text, @"images\\" + fileName);
                MessageBox.Show("Employee was added");
                TxtUserNo.Clear();
                TextBoxName.Clear();
                TextBoxSurName.Clear();
                TextBoxImagePath.Clear();
                pictureBox1 = null;
                comboFull = false;
                CmbDepartment.SelectedIndex = -1;
                CmbPosition.SelectedIndex = -1;
                CmbPosition.DataSource = dto.Positions;
                comboFull = true;
                TextboxSalary.Clear();
                textBox1.Clear();
                dateTimePicker1.Value = DateTime.Today;
                TextBoxPassword.Clear();
                ChAdmin.Checked = false;
            }
        }

        private void TxtUserNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            if (TxtUserNo.Text.Trim() == "")
            {
                MessageBox.Show("User number field is empty");
            }
            else
            {
                if(IsUniqueNo())
                {
                    MessageBox.Show($"{TxtUserNo.Text} can be used");
                }
                else
                {
                    MessageBox.Show($"{TxtUserNo.Text} not available");
                }
            }
        }

        private bool IsUniqueNo()
        {
            return EmployeeBLL.IsUnique(Convert.ToInt32(TxtUserNo.Text));
            
        }
    }
}

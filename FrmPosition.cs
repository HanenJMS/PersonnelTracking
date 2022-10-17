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
    public partial class FrmPosition : Form
    {
        public FrmPosition()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(TextBoxPosition.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a position");
            }
            else if(CmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a valid department");
            }
            else
            {
                POSITION position = new POSITION();
                position.PositionName = TextBoxPosition.Text;
                position.DepartmentID = Convert.ToInt32(CmbDepartment.SelectedValue);
                PositionBLL.AddPosition(position);
                MessageBox.Show("Position was sucessfully added");
                TextBoxPosition.Clear();
                CmbDepartment.SelectedIndex = -1;
            }
            
        }

        private void FrmPosition_Load(object sender, EventArgs e)
        {
            ShowDepList();
        }

        private void ShowDepList()
        {
            List<DEPARTMENT> dList = new List<DEPARTMENT>();
            dList = DepartmentBLL.GetDepartments();
            CmbDepartment.DataSource = dList;
            CmbDepartment.DisplayMember = "DepartmentName";
            CmbDepartment.ValueMember = "ID";
            CmbDepartment.SelectedIndex = -1;
        }
    }
}

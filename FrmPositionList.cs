using BLL;
using DAL;
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
    public partial class FrmPositionList : Form
    {
        public FrmPositionList()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FrmPosition frm = new FrmPosition();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            ShowGrid();

        }

        private void FrmPositionList_Load(object sender, EventArgs e)
        {
            ShowGrid();
        }

        private void ShowGrid()
        {
            List<PositionDTO> pList = new List<PositionDTO>();
            pList = PositionBLL.GetPositions();
            DataPositionList.DataSource = pList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingApp
{
    public partial class frm_DepartmentwiseBeds : Form
    {
        clsConsolers clsConsole = new clsConsolers();
        public frm_DepartmentwiseBeds()
        {
            InitializeComponent();
            clsConsole.fill_Dept(ddlDept);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int Dept = Convert.ToInt32(ddlDept.SelectedValue.ToString());


            if (Dept > 0)
            {
                clsConsole.SearchBeds_Deptwise(lstPersonSubwise, Dept);
            }
        }

        
    }
}

﻿using System;
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
    public partial class frmSearchwithDistance : Form
    {
        clsConsolers varInsert = new clsConsolers();
        public frmSearchwithDistance()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            //varInsert.callProductData(lstTeachers);

            int value = Convert.ToInt32(txtValue.Text);
            varInsert.callProductData(lstTeachers, value);



        }

        
    }
}

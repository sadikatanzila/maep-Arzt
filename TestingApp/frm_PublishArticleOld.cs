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
    public partial class frm_PublishArticleOld : Form
    {
        clsConsolersOldData clsConsole = new clsConsolersOldData();
        public frm_PublishArticleOld()
        {
            InitializeComponent();
            clsConsole.fill_ArticleType(ddlArticle);
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "" && txtDetails.Text != "")
            {
                string date = dtPublish.Value.ToString("yyyy-MM-dd");
                //string timeStamp = GetTimestamp(DateTime.Now);
                DateTime Curnt_Time;
                Curnt_Time = Convert.ToDateTime(DateTime.Now);
                string InsertAt = Curnt_Time.ToString("yyyy-MM-dd HH:mm:ss");
                lblMessage.Visible = false;
                lblMessage.Text = "";
                clsConsole.InsertIntoArticleOld(Convert.ToInt32(ddlArticle.SelectedValue.ToString()), txtTitle.Text, txtHeadline.Text, txtDetails.Text, date, InsertAt);
                clearAll();
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Please Enter your Article Name and details";
            }


        }


        void clearAll()
        {
            ddlArticle.SelectedIndex = 0;
            txtTitle.Text = "";
            txtDetails.Text = "";
            lblMessage.Visible = false;
            lblMessage.Text = "";
            txtHeadline.Text = "";

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using TestingApp.Properties;
using System.ComponentModel;
using System.Drawing;




namespace TestingApp
{
    class clsConsolersOldData
    {
        private MySqlDataAdapter da;
        private MySqlCommand cmd;

        SQLConfig config = new SQLConfig();

        usableFunction funct = new usableFunction();
        public DataTable dt;

        //VIEW PRODUCT
        private MySqlConnection con = new MySqlConnection("server=db505320538.1and1-data.host;user=dbo505320538;database=db505320538;port=3306;password=maepDD2014");
        


        public void fill_ArticleType(ComboBox ArticleID)
        {
            string sql = @"select * from ArticleType order by Name asc;";
            MySqlCommand cmd = new MySqlCommand(sql);

            fiil_CBO(sql, ArticleID);

        }

        public void fiil_CBO(string sql, ComboBox cbo)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                cbo.DataSource = dt;
                cbo.ValueMember = dt.Columns[0].ColumnName;
                cbo.Text = dt.Columns[1].ColumnName;
                cbo.DisplayMember = dt.Columns[1].ColumnName;
                //cbo.


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }

        }
        public void InsertIntoArticleOld(int ArticleTypeID, string title,string HeadlineText, string Details, string date, string crntdate)
        {
            try
            {
                string messageTrue, messageFalse;

                //  string dbPath = @"Data Source=SONY\MSSQLSERVER00V1;Initial Catalog=dbOHMS;Integrated Security=True";
                string sql = @"insert into Article (ArticleTypeID, Header, HeadlineText ,Details, eventdate, CreatedAt) 
                    values(" + ArticleTypeID + ",'" + title + "', '" + HeadlineText + "','" + Details + "','" + date + "' ,'" + crntdate + "'   )";
                MySqlCommand cmd = new MySqlCommand(sql);

                messageTrue = "Article has been saved.";
                messageFalse = "Failed to save a Article.";
                config.Execute_CUD(sql, messageFalse, messageTrue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        

    }

 
}
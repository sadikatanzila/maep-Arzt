﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace TestingApp
{
    class SQLConfig
    {
        // string connStr = "server=78.46.106.198;user=root;database=drfuture.database;port=23306;password=GZ9bzSr9B?4kA!8#";
        //private MySqlConnection con = new MySqlConnection("server=78.46.106.198;user=root;database=drfuture.database;port=23306;password=GZ9bzSr9B?4kA!8#"); //previous
        private MySqlConnection con = new MySqlConnection("server=screenfx.de;user=d036c030;database=d036c030;port=3306;password=g5ZReBPD2ADDXT6V");
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        public DataTable dt;
        MySqlDataReader reader;

        int result;
        int getReceiptNum;
        usableFunction funct = new usableFunction();
        public void Execute_CUD(string sql, string msg_false, string msg_true)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();

                if(result > 0)
                {
                    MessageBox.Show(msg_true);
                }
                else
                {
                    MessageBox.Show(msg_false);
                } 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close(); 
            }
        }
        public void Execute_Query(string sql)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void Load_DTG(string sql,DataGridView dtg)
        {
            try
            {
                //con.Open();
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
                dtg.DataSource = dt;

               
                funct.ResponsiveDtg(dtg);
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }

        }

        public DataTable get_viewData(string query, string tableName)
        {
            DataSet ds = new DataSet();
            da = new MySqlDataAdapter(query, con);
            try
            {
                con.Open();
                da.Fill(ds, "" + tableName);
            }
            catch (Exception e)
            {
                ds.Tables.Add("" + tableName);
            }
            finally { con.Close(); }
            return ds.Tables["" + tableName];
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
        public void combo(string sql, ComboBox cbo)
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

                cbo.Items.Clear();
                cbo.Text = "Select";
                foreach(DataRow r in dt.Rows)
                {
                    cbo.Items.Add(r.Field<string>(0));
                }


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
        public void singleResult(string sql)

        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);  


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }
        }

        public void loadReports(string sql)

        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

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

        public void autocomplete(string sql,TextBox txt)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);
                txt.AutoCompleteCustomSource.Clear();
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                foreach (DataRow r in dt.Rows)
                {
                    txt.AutoCompleteCustomSource.Add(r.Field<string>(0));
                }


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

        public void autonumber(string AUTOKEY, TextBox txt)
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
                cmd.CommandText = "SELECT CONCAT(`Autonumber`,`EndValue`) FROM `tblautonumber` WHERE Remarks='" + AUTOKEY + "'";
                da.SelectCommand = cmd;
                da.Fill(dt);

                txt.Text = DateTime.Now.ToString("yyyy") + dt.Rows[0].Field<string>(0);
            

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
        public void update_Autonumber(string id)
        { 
            Execute_Query("UPDATE `tblautonumber` SET `END`=`END`+`INCREMENT` WHERE `DESCRIPTION`='" + id + "'");
        }
       
        public int GetMedical_ID(string sql)
        {

            try
            {
               // cmd = new MySqlCommand();
                con.Open();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter();
                //dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);


                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    getReceiptNum = Int16.Parse(reader["ID"].ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return getReceiptNum;

        }

    }
}

using Nhom01.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ThongKeHangHoa : Form
    {
        SqlConnection ConnectionSTR;
        string Guest;
        string LoadST = "onload";
        string[] Product_ID = { };
        string[] Product_Name = { };

        public ThongKeHangHoa(string Guest)
        {
            InitializeComponent();
            this.Guest = Guest;
        }
        private void TableLoads(int month, int year)
        {
            string inout = "";
            SqlCommand cmd;
            SqlDataReader read;

            DataTable dt = new DataTable();

            DataColumn dc = new DataColumn("Product's ID");
            dt.Columns.Add(dc);
            dc = new DataColumn("Product's Name");
            dt.Columns.Add(dc);
            dc = new DataColumn("Out");
            dt.Columns.Add(dc);
            dc = new DataColumn("In");
            dt.Columns.Add(dc);
            try
            {
                ConnectionSTR.Open();

                for (int i = 0; i < Product_ID.Length; i++)
                {
                    inout += "Exec dbo.thongkeHangHoaRaVao '" + Product_ID[i] + "'," + month + "," + year;

                    cmd = new SqlCommand(inout, ConnectionSTR);

                    string proIn = "0", proOut = "0";

                    cmd = new SqlCommand(inout, ConnectionSTR);
                    read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        proOut = read.GetInt32(0).ToString();
                        proIn = read.GetInt32(1).ToString();
                    }
                    read.Close();

                    DataRow dr = dt.NewRow();
                    dr["Product's ID"] = Product_ID[i];
                    dr["Product's Name"] = Product_Name[i];
                    dr["Out"] = proOut;
                    dr["In"] = proIn;
                    dt.Rows.Add(dr);

                    inout = "";
                }

                ConnectionSTR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (dt.Rows.Count > 0)
            {
                productStatisticTable.DataSource = dt;

                productStatisticTable.Columns[0].Width = 125;
                productStatisticTable.Columns[2].Width = 100;
                productStatisticTable.Columns[3].Width = 100;

                productStatisticTable.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productStatisticTable.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                productStatisticTable.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productStatisticTable.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                productStatisticTable.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                productStatisticTable.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;


                productStatisticTable.Rows[0].Cells[0].Selected = true;
            }
            else
            {
                dt = new DataTable();
                productStatisticTable.DataSource = dt;
            }
        }
        private void FrmTKHH_Load(object sender, EventArgs e)
        {
            ConnectionSTR = new SqlConnection(DataP.Instance.connectSTR);
            CreatePage();
        }


        private void CreatePage()
        {
            cbmonth.SelectedIndex = 0;
            cbyear.SelectedIndex = 0;
            try
            {
                ConnectionSTR.Open();
                string prod = "Select MaHang,TenMatHang From HangHoa";
                SqlCommand cmd = new SqlCommand(prod, ConnectionSTR);
                SqlDataReader rd = cmd.ExecuteReader();
                List<string> tmpid = new List<string>();
                List<string> tmpname = new List<string>();
                while (rd.Read())
                {
                    tmpid.Add(rd.GetString(0));
                    tmpname.Add(rd.GetString(1));
                }
                rd.Close();
                Product_ID = tmpid.ToArray();
                Product_Name = tmpname.ToArray();

                ConnectionSTR.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            Load_All(2020);

            LoadST = "Finish";
        }

       
        private void comboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LoadST.Equals("Finish"))
            {
                ReadloadGIO();
            }
        }
        private void comboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LoadST.Equals("Finish"))
            {
                ReadloadGIO();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMain_kt back = new FormMain_kt(Guest);
            this.Hide();
            back.ShowDialog();
            this.Close();
        }
        private void Load_All(int year)
        {
            string inout = "";
            SqlCommand cmd;
            SqlDataReader read;

            DataTable dt = new DataTable();

            DataColumn dc = new DataColumn("Product's ID");
            dt.Columns.Add(dc);
            dc = new DataColumn("Product's Name");
            dt.Columns.Add(dc);
            dc = new DataColumn("Out");
            dt.Columns.Add(dc);
            dc = new DataColumn("In");
            dt.Columns.Add(dc);
            try
            {
                ConnectionSTR.Open();

                for (int i = 0; i < Product_ID.Length; i++)
                {
                    int proIn = 0, proOut = 0;
                    for (int m = 1; m <= 12; m++)
                    {
                        inout += "Exec dbo.thongkeHangHoaRaVao '" + Product_ID[i] + "'," + m + "," + year;
                        cmd = new SqlCommand(inout, ConnectionSTR);
                        cmd = new SqlCommand(inout, ConnectionSTR);
                        read = cmd.ExecuteReader();
                        while (read.Read())
                        {
                            proOut += read.GetInt32(0);
                            proIn += read.GetInt32(1);
                        }
                        read.Close();
                        inout = "";

                    }

                    DataRow dr = dt.NewRow();
                    dr["Product's ID"] = Product_ID[i];
                    dr["Product's Name"] = Product_Name[i];
                    dr["Out"] = proOut+"";
                    dr["In"] = proIn+"";
                    dt.Rows.Add(dr);

                }

                ConnectionSTR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (dt.Rows.Count > 0)
            {
                productStatisticTable.DataSource = dt;

                productStatisticTable.Columns[0].Width = 125;
                productStatisticTable.Columns[2].Width = 100;
                productStatisticTable.Columns[3].Width = 100;

                productStatisticTable.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productStatisticTable.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                productStatisticTable.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productStatisticTable.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                productStatisticTable.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                productStatisticTable.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

                productStatisticTable.Rows[0].Cells[0].Selected = true;
            }
            else
            {
                dt = new DataTable();
                productStatisticTable.DataSource = dt;
            }
        }

        private void ReadloadGIO()
        {
            int month = 0;
            int year = 0;
            month = cbmonth.SelectedItem.ToString().Equals("All")?0:int.Parse(cbmonth.SelectedItem.ToString());
            year = int.Parse(cbyear.SelectedItem.ToString());
            if(month == 0)
            {
                Load_All(year);
            }
            else
            {
                TableLoads(month, year);
            }
        }


      
    }
}

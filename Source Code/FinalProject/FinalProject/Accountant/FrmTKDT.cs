using Nhom01.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FormThongkeDT : Form
    {
        string Guest;
        SqlConnection ConnectionSTR;

        string loadST = "onload";
        public FormThongkeDT(string Guest)
        {
            InitializeComponent();
            this.Guest = Guest;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
           
        }

        private void moreBtn_Click(object sender, EventArgs e)
        {
            
        }
        private void FrmTKDT_Load(object sender, EventArgs e)
        {
            ConnectionSTR =new SqlConnection(DataP.Instance.connectSTR);
            PageCreate();
        }

        private void PageCreate()
        {
            string[] month = { "All", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            string[] year = { "All", "2020", "2021", "2022" };
            cbmonth.Items.AddRange(month);
            cbyear.Items.AddRange(year);

            cbmonth.SelectedIndex = 0;
            cbyear.SelectedIndex = 0;
            loadST = "finish";

            btntotal.Enabled = false;
            noData.Visible = false;

            ReloadSTtable();
        }
        
        private void LoadTableST()
        {
            string export = "",import = "";
            SqlCommand cmde,cmdi;
            SqlDataReader exportRead, importRead;

            DataTable dt = new DataTable();

            DataColumn dc = new DataColumn("Month");
            dt.Columns.Add(dc);
            dc = new DataColumn("Year");
            dt.Columns.Add(dc);
            dc = new DataColumn("Spend");
            dt.Columns.Add(dc);
            dc = new DataColumn("Income");
            dt.Columns.Add(dc);

            try
            {
                ConnectionSTR.Open();
                for(int y = 2020; y <= 2022; y++)
                {
                    for (int m = 1; m <= 12; m++)
                    {
                        export += "Exec EmportByMonth " + m + "," + y;
                        import += "Exec ImportByMonth " + m + "," + y;

                        cmde = new SqlCommand(export, ConnectionSTR);

                        string income = "No Income", spend = "No Spend";

                        exportRead = cmde.ExecuteReader();
                        while(exportRead.Read())
                        {
                            income = exportRead.GetSqlInt64(2).ToString();
                        }
                        exportRead.Close();

                        cmdi = new SqlCommand(import, ConnectionSTR);
                        importRead = cmdi.ExecuteReader();
                        while(importRead.Read())
                        {
                            spend = importRead.GetSqlInt64(2).ToString();
                        }
                        importRead.Close();

                        if(!income.Equals("No Income") | !spend.Equals("No Spend"))
                        {
                            DataRow dr = dt.NewRow();
                            dr["Month"] = m;
                            dr["Year"] = y;
                            dr["Income"] = income;
                            dr["Spend"] = spend;
                            dt.Rows.Add(dr);
                        }
                        export = "";
                        import = "";
                    }
                }
                
                ConnectionSTR.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (dt.Rows.Count > 0)
            {
                statisticTables.DataSource = dt;
                statisticTables.Rows[0].Cells[0].Selected = true;
                btntotal.Enabled = true;
                noData.Visible = false;
            }
            else
            {
                dt = new DataTable();
                statisticTables.DataSource = dt;
                btntotal.Enabled = false;
                noData.Visible = true;
            }
        }
        private void LoadTableST_Year(int year)
        {
            string export = "", import = "";
            SqlCommand cmde, cmdi;
            SqlDataReader exportRead, importRead;

            DataTable dt = new DataTable();

            DataColumn dc = new DataColumn("Month");
            dt.Columns.Add(dc);
            dc = new DataColumn("Year");
            dt.Columns.Add(dc);
            dc = new DataColumn("Spend");
            dt.Columns.Add(dc);
            dc = new DataColumn("Income");
            dt.Columns.Add(dc);

            try
            {
                ConnectionSTR.Open();
                for (int m = 1; m <= 12; m++)
                {
                    export += "Exec EmportByMonth " + m + "," + year;
                    import += "Exec ImportByMonth " + m + "," + year;
                    cmde = new SqlCommand(export, ConnectionSTR);

                    string income = "No Income", spend = "No Spend";

                    exportRead = cmde.ExecuteReader();
                    while (exportRead.Read())
                    {
                        income = exportRead.GetSqlInt64(2).ToString();
                    }
                    exportRead.Close();

                    cmdi = new SqlCommand(import, ConnectionSTR);
                    importRead = cmdi.ExecuteReader();
                    while (importRead.Read())
                    {
                        spend = importRead.GetSqlInt64(2).ToString();
                    }
                    importRead.Close();

                    if (!income.Equals("No Income") | !spend.Equals("No Spend"))
                    {
                        DataRow dr = dt.NewRow();
                        dr["Month"] = m;
                        dr["Year"] = year;
                        dr["Spend"] = spend;
                        dr["Income"] = income;
                        dt.Rows.Add(dr);
                    }
                    export = "";
                    import = "";
                }

                ConnectionSTR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            if (dt.Rows.Count > 0)
            {
                statisticTables.DataSource = dt;
                statisticTables.Rows[0].Cells[0].Selected = true;
                btntotal.Enabled = true;
                noData.Visible = false;
            }
            else
            {
                dt = new DataTable();
                statisticTables.DataSource = dt;
                btntotal.Enabled = false;
                noData.Visible = true;
            }
        }

        private void ReloadSTtable()
        {
            int month = 0;
            int year = 0;
            if ((cbmonth.SelectedItem.ToString().Length > 0) & (cbyear.SelectedItem.ToString().Length > 0))
            {
                month = cbmonth.SelectedItem.ToString().Equals("All") ? 0 : int.Parse(cbmonth.SelectedItem.ToString());
                year = cbyear.SelectedItem.ToString().Equals("All") ? 0 : int.Parse(cbyear.SelectedItem.ToString());
            }
            else { }

            txtcome.Text = "";
            txtspen.Text = "";
            txtover.Text = "";

            if (month == 0 & year == 0)
            {
                LoadTableST();
            }
            else if (month != 0 & year != 0)
            {
                LoadTableST_MonthAndYear(month, year);
            }
            else if (month != 0)
            {
                LoadTableST_Month(month);
            }
            else
            {
                LoadTableST_Year(year);
            }

            if (statisticTables.Rows.Count > 0)
            {
                statisticTables.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                statisticTables.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void statisticTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int income = 0;
            int spend = 0;
            int rowindex = statisticTables.SelectedRows[0].Index;
            statisticTables.Rows[rowindex].Selected = true;

            string tmp1 = statisticTables.Rows[rowindex].Cells[2].Value.ToString();
            string tmp2 = statisticTables.Rows[rowindex].Cells[3].Value.ToString();

            if (!tmp1.Equals("No Spend"))
            {
                spend += int.Parse(tmp1);
            }
            else { }

            if (!tmp2.Equals("No Income"))
            {
                income += int.Parse(tmp2);
            }
            else { }

            if (income == 0) { txtcome.Text = "0"; } else { txtcome.Text = income + " k"; }
            if (spend == 0) { txtspen.Text = "0"; } else { txtspen.Text = spend + " k"; }
            if (income - spend < 0) { txtover.Text = "Loss: " + (spend - income) + " k"; } else { txtover.Text = "Profit: " + (income - spend) + " k"; }
        }
        private void comboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadST.Equals("finish"))
            {
                ReloadSTtable();
            }
        }

        private void LoadTableST_MonthAndYear(int month, int year)
        {
            string export = "", import = "";
            SqlCommand cmde, cmdi;
            SqlDataReader exportRead, importRead;

            DataTable dt = new DataTable();

            DataColumn dc = new DataColumn("Month");
            dt.Columns.Add(dc);
            dc = new DataColumn("Year");
            dt.Columns.Add(dc);
            dc = new DataColumn("Spend");
            dt.Columns.Add(dc);
            dc = new DataColumn("Income");
            dt.Columns.Add(dc);

            try
            {
                ConnectionSTR.Open();

                export += "Exec EmportByMonth " + month + "," + year;
                import += "Exec ImportByMonth " + month + "," + year;

                cmde = new SqlCommand(export, ConnectionSTR);

                string income = "No Income", spend = "No Spend";

                exportRead = cmde.ExecuteReader();
                while (exportRead.Read())
                {
                    income = exportRead.GetSqlInt64(2).ToString();
                }
                exportRead.Close();

                cmdi = new SqlCommand(import, ConnectionSTR);
                importRead = cmdi.ExecuteReader();
                while (importRead.Read())
                {
                    spend = importRead.GetSqlInt64(2).ToString();
                }
                importRead.Close();

                if (!income.Equals("No Income") | !spend.Equals("No Spend"))
                {
                    DataRow dr = dt.NewRow();
                    dr["Month"] = month;
                    dr["Year"] = year;
                    dr["Income"] = income;
                    dr["Spend"] = spend;
                    dt.Rows.Add(dr);
                }
                export = "";
                import = "";

                ConnectionSTR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            if (dt.Rows.Count > 0)
            {
                statisticTables.DataSource = dt;
                statisticTables.Rows[0].Cells[0].Selected = true;
                btntotal.Enabled = true;
                noData.Visible = false;
            }
            else
            {
                dt = new DataTable();
                statisticTables.DataSource = dt;
                btntotal.Enabled = false;
                noData.Visible = true;
            }
        }
        private void LoadTableST_Month(int month)
        {
            string export = "", import = "";
            SqlCommand cmde, cmdi;
            SqlDataReader exportRead, importRead;

            DataTable dt = new DataTable();

            DataColumn dc = new DataColumn("Month");
            dt.Columns.Add(dc);
            dc = new DataColumn("Year");
            dt.Columns.Add(dc);
            dc = new DataColumn("Spend");
            dt.Columns.Add(dc);
            dc = new DataColumn("Income");
            dt.Columns.Add(dc);

            try
            {
                ConnectionSTR.Open();
                for (int y = 2020; y <= 2022; y++)
                {
                    export += "Exec EmportByMonth " + month + "," + y;
                    import += "Exec ImportByMonth " + month + "," + y;

                    cmde = new SqlCommand(export, ConnectionSTR);

                    string income = "No Income", spend = "No Spend";

                    exportRead = cmde.ExecuteReader();
                    while (exportRead.Read())
                    {
                        income = exportRead.GetSqlInt64(2).ToString();
                    }
                    exportRead.Close();

                    cmdi = new SqlCommand(import, ConnectionSTR);
                    importRead = cmdi.ExecuteReader();
                    while (importRead.Read())
                    {
                        spend = importRead.GetSqlInt64(2).ToString();
                    }
                    importRead.Close();

                    if (!income.Equals("No Income") | !spend.Equals("No Spend"))
                    {
                        DataRow dr = dt.NewRow();
                        dr["Month"] = month;
                        dr["Year"] = y;
                        dr["Income"] = income;
                        dr["Spend"] = spend;
                        dt.Rows.Add(dr);
                    }
                    export = "";
                    import = "";
                }

                ConnectionSTR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            if (dt.Rows.Count > 0)
            {
                statisticTables.DataSource = dt;
                statisticTables.Rows[0].Cells[0].Selected = true;
                btntotal.Enabled = true;
                noData.Visible = false;
            }
            else
            {
                dt = new DataTable();
                statisticTables.DataSource = dt;
                btntotal.Enabled = false;
                noData.Visible = true;
            }
        }
     
        private void comboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadST.Equals("finish"))
            {
                ReloadSTtable();
            }
        }
        private void allBtn_Click(object sender, EventArgs e)
        {
            int income = 0;
            int spend = 0;
            for(int i = 0; i < statisticTables.RowCount; i++)
            {
                string tmp1 = statisticTables.Rows[i].Cells[2].Value.ToString();
                string tmp2 = statisticTables.Rows[i].Cells[3].Value.ToString();

                if (!tmp1.Equals("No Spend"))
                {
                    spend += int.Parse(tmp1);
                }
                else { }

                if (!tmp2.Equals("No Income"))
                {
                    income += int.Parse(tmp2);
                }
                else { }
            }

            statisticTables.SelectAll();

            if (income == 0) { txtcome.Text = "0"; } else{txtcome.Text = income + " k"; }
            if (spend == 0) { txtspen.Text = "0";}else{ txtspen.Text = spend + " k";}
            if (income - spend < 0){txtover.Text = "Loss: " + (spend - income) + " k";}else{txtover.Text = "Profit: " + (income - spend) + " k";}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMain_kt back = new FormMain_kt(Guest);
            this.Hide();
            back.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ThongKeHangHoa moreinfo = new ThongKeHangHoa(Guest);
            this.Hide();
            moreinfo.ShowDialog();
            this.Close();
        }
    }
}

using Nhom01.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Order : Form
    {
        SqlConnection conn;
        string userid="";
        public Order(string userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        private void Order_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(DataP.Instance.connectSTR);
            initPage();
        }
        private void initPage()
        {

            try
            {
                conn.Open();

                orderInfo.Visible = false;
                loadProduct();
                

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            btnBank.Checked = true;
        }
        private void loadProduct()
        {
            string command = "Select MaHang,TenMatHang,DonVi,Cast(GiaBan as bigint) From HangHoa Order by TenMatHang";
            SqlCommand cmd = new SqlCommand(command, conn);

            SqlDataReader read = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn("Product's id");
            dt.Columns.Add(dc);
            dc = new DataColumn("Product's name");
            dt.Columns.Add(dc);
            dc = new DataColumn("Unit Type");
            dt.Columns.Add(dc);
            dc = new DataColumn("Price");
            dt.Columns.Add(dc);
            dc = new DataColumn("Quantity");
            dt.Columns.Add(dc);

            while (read.Read())
            {
                DataRow dr = dt.NewRow();
                dr["Product's id"] = read.GetString(0);
                dr["Product's name"] = read.GetString(1);
                dr["Unit Type"] = read.GetString(2);
                dr["Price"] = read.GetSqlInt64(3).ToString();
                dr["Quantity"] = "0";

                dt.Rows.Add(dr);
            }
            if (dt.Rows.Count > 0)
            {
                dataProduct.DataSource = dt;
                dataProduct.Columns[0].ReadOnly = true;
                dataProduct.Columns[1].ReadOnly = true;
                dataProduct.Columns[2].ReadOnly = true;
                dataProduct.Columns[3].ReadOnly = true;

                dataProduct.Columns[0].Width = 100;
                dataProduct.Columns[2].Width = 100;
                dataProduct.Columns[3].Width = 100;
                dataProduct.Columns[4].Width = 100;

                dataProduct.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataProduct.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dataProduct.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataProduct.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dataProduct.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataProduct.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataProduct.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataProduct.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataProduct.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataProduct.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


                dataProduct.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataProduct.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataProduct.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                for(int i = 0; i < dataProduct.ColumnCount; i++)
                {
                    dataProduct.Columns[i].HeaderCell.Style.Font = new Font("Arial", 14F,FontStyle.Bold,GraphicsUnit.Pixel);
                    dataProduct.Columns[i].DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
                }
            }
        }

        private void loadOrder(int rowcount)
        {
            DataTable dt = new DataTable();

            DataColumn dc = new DataColumn("Product's ID");
            dt.Columns.Add(dc);

            dc = new DataColumn("Product's Name");
            dt.Columns.Add(dc);

            dc = new DataColumn("Unit");
            dt.Columns.Add(dc);

            dc = new DataColumn("Price (k)");
            dt.Columns.Add(dc);

            dc = new DataColumn("Quantity");
            dt.Columns.Add(dc);

            int row = 0;
            int total = 0;
            for (int j = 0; j < dataProduct.RowCount & row < rowcount; j++)
            {
                string id = dataProduct.Rows[j].Cells[0].Value.ToString();
                string name = dataProduct.Rows[j].Cells[1].Value.ToString();
                string unit = dataProduct.Rows[j].Cells[2].Value.ToString();
                int price = int.Parse(dataProduct.Rows[j].Cells[3].Value.ToString());
                int quantity = 0;

                quantity = int.Parse(dataProduct.Rows[j].Cells[4].Value.ToString());
                if (quantity > 0)
                {

                    quantity = int.Parse(dataProduct.Rows[j].Cells[4].Value.ToString().TrimStart('0'));
                    DataRow dr = dt.NewRow();

                    dr["Product's ID"] = id;
                    dr["Product's Name"] = name;
                    dr["Price (k)"] = price+"";
                    dr["Unit"] = unit;
                    dr["Quantity"] = quantity;
                    total += quantity * price;
                    dt.Rows.InsertAt(dr, row);
                    row++;
                }
            }
            dataOrder.DataSource = dt;

            dataOrder.Columns[0].Width = 100;
            dataOrder.Columns[2].Width = 100;
            dataOrder.Columns[3].Width = 100;
            dataOrder.Columns[4].Width = 100;


            dataOrder.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataOrder.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataOrder.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataOrder.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataOrder.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataOrder.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataOrder.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataOrder.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataOrder.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            txtTotal.Text = "Total: " + total + " k";

            for (int i = 0; i < dataOrder.ColumnCount; i++)
            {
                dataOrder.Columns[i].HeaderCell.Style.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
                dataOrder.Columns[i].DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int rowcount = 0;

           for (int i = 0; i < dataProduct.RowCount; i++)
           {
                string testcase = "";
                if (dataProduct.Rows[i].Cells[4].Value == null)
                {
                    dataProduct.Rows[i].Cells[4].Value = "0";
                }

                if (dataProduct.Rows[i].Cells[4].Value.ToString().Trim().Length != 0)
                {
                    testcase = dataProduct.Rows[i].Cells[4].Value.ToString().Trim();
                    if (int.TryParse(testcase, out int value))
                    {
                        if (int.Parse(testcase) > 0)
                        {
                            rowcount += 1;
                        }
                        else if (int.Parse(testcase) < 0)
                        {
                            TT2.ShowBalloonTip(50);
                            return;
                        }
                        else { }
                    }
                    else
                    {
                        TT1.ShowBalloonTip(50);
                        return;
                    }
                }
           }

            if (rowcount == 0)
            {
                MessageBox.Show("Nothing to show");
                return;
            }
            else
            {
                loadOrder(rowcount);
                orderInfo.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataOrder.Refresh();
            orderInfo.Visible = false;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string paymethod = (btnBank.Checked) ? "Banking" : "Momo";
            try
            {
                conn.Open();
                string command = "exec themPhieuDatHang '" + userid + "','" + paymethod + "'";
                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataReader read = cmd.ExecuteReader();
                read.Read();
                string billid = read.GetString(0);
                read.Close();

                for(int i = 0; i < dataOrder.RowCount; i++)
                {
                    string proid = dataOrder.Rows[i].Cells[0].Value.ToString();
                    int quantity = int.Parse(dataOrder.Rows[i].Cells[4].Value.ToString());
                    command = "exec dbo.themDanhSachDatHang '" + billid + "','"+proid+"',"+quantity;
                    cmd = new SqlCommand(command, conn);
                    read = cmd.ExecuteReader();
                    read.Close();
                }
                
                MessageBox.Show("Đặt hàng thành công");
                this.Close();
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

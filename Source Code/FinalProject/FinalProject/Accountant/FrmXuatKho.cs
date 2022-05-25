using Nhom01.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Xuat : Form
    {
        SqlConnection conn;
        string user,exportId="";
        object send;
        EventArgs eArgs;

        public Xuat(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FrmXuatKho_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(DataP.Instance.connectSTR);
            send = sender;
            eArgs = e;

            try
            {
                conn.Open();

                loadUnprocessed();
                loadOnBeingShipped();
                loadHaveArrived();

                clearForm();

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Check ConnectSQL.cs file! ");
            }

        }
        private void loadUnprocessed()
        {
            string command = "Select SoPhieu [Bill ID], ID_NguoiDat [User ID], NgayDatHang [Order date] ";
            command += "From PhieuDatHang Where TrangThai = 'On pending'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command,conn);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            Int64 rowcount = tableExist(command);
            if (rowcount == 0) { return; } else { }


            dataAdapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                unprocessedList.DataSource = ds.Tables[0];

                unprocessedList.Columns[0].Width = 111;
                unprocessedList.Columns[1].Width = 111;

                for (int i = 0; i < unprocessedList.ColumnCount; i++)
                {
                    unprocessedList.Columns[i].HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                    unprocessedList.Columns[i].DefaultCellStyle.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Pixel);

                }


                unprocessedList.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                unprocessedList.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

                unprocessedList.Columns[2].DefaultCellStyle.Format = "MMM dd yyyy";
            }
            else {
                ds = new DataSet();
                unprocessedList.DataSource = ds.Tables[0];
            }
           

            unprocessedList.ClearSelection();
        }
        
        
        private void loadOnBeingShipped()
        {
            string command = "Select XK.SoPhieu [Export ID],DH.SoPhieu [Order ID], DH.NgayDatHang [Order_date], XK.NgayXuatKho [Delivery_Date] ";
            command += "From PhieuDatHang DH ";
            command += "Left Join PhieuXuatKho XK ";
            command += "On DH.SoPhieu = XK.SoPhieuDat ";
            command += "Where TrangThai = 'On being shipped' ";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command, conn);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            Int64 rowcount = tableExist(command);
            if (rowcount == 0) { return;  } else { }


            dataAdapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                onshippedList.DataSource = ds.Tables[0];

                for (int i = 0; i < onshippedList.ColumnCount; i++)
                {
                    onshippedList.Columns[i].Width = 111;
                    onshippedList.Columns[i].HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                    onshippedList.Columns[i].DefaultCellStyle.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Pixel);

                }

                onshippedList.Columns[2].DefaultCellStyle.Format = "MMM dd yyyy";
                onshippedList.Columns[3].DefaultCellStyle.Format = "MMM dd yyyy";

                onshippedList.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                onshippedList.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            else
            {
                ds = new DataSet();
                onshippedList.DataSource = ds.Tables[0];
            }
            
            onshippedList.ClearSelection();
        }

        private void loadHaveArrived()
        {
            string command = "Select XK.SoPhieu [Số phiếu], DH.NgayDatHang [Ngày đặt hàng], XK.NgayXuatKho [Ngày xuất kho],DH.NgayNhanHang [Ngày nhận hàng], DH.PT_ThanhToan [Phương thức thanh toán]";
            command += "From PhieuDatHang DH ";
            command += "Left Join PhieuXuatKho XK ";
            command += "On DH.SoPhieu = XK.SoPhieuDat ";
            command += "Where TrangThai = 'Have Arrived' Order by DH.NgayNhanHang DESC";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command, conn);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            Int64 rowcount = tableExist(command);
            if (rowcount == 0) { return; } else { }


            dataAdapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                havearrivedList.DataSource = ds.Tables[0];

                for (int i = 0; i < havearrivedList.ColumnCount; i++)
                {
                    havearrivedList.Columns[i].Width = 111;
                    havearrivedList.Columns[i].HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                    havearrivedList.Columns[i].DefaultCellStyle.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
                }
                havearrivedList.Columns[1].DefaultCellStyle.Format = "MMM dd yyyy";
                havearrivedList.Columns[2].DefaultCellStyle.Format = "MMM dd yyyy";
                havearrivedList.Columns[3].DefaultCellStyle.Format = "MMM dd yyyy";

                havearrivedList.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                havearrivedList.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            else
            {
                ds = new DataSet();
                havearrivedList.DataSource = ds.Tables[0];
            }

            havearrivedList.ClearSelection();
        }

        private Int64 tableExist(String command)
        {
            Int64 rCount = 0;
            SqlCommand cmd = new SqlCommand(command, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                rCount += 1;
            }

            reader.Close();
            return rCount;
        }
        private void unprocessedList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = unprocessedList.SelectedCells[0].RowIndex;
            unprocessedList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            unprocessedList.Rows[rowindex].Selected = true;

            if (onshippedList.RowCount > 0)
            {
                onshippedList.SelectionMode = DataGridViewSelectionMode.CellSelect;
                onshippedList.Rows[0].Cells[0].Selected = true;
            }
            if (havearrivedList.RowCount > 0)
            {
                havearrivedList.SelectionMode = DataGridViewSelectionMode.CellSelect;
                havearrivedList.Rows[0].Cells[0].Selected = true;
            }
            
            string billID = unprocessedList.Rows[rowindex].Cells[0].Value.ToString();
            string ordererID = unprocessedList.Rows[rowindex].Cells[1].Value.ToString();

            try
            {
                conn.Open();

                DateTime dateOrder = DateTime.Parse(unprocessedList.Rows[rowindex].Cells[2].Value.ToString());
                if (dateOrder < DateTime.Now)
                {
                    datePicker.Value = DateTime.Now;
                }
                else
                {
                    datePicker.Value = dateOrder.AddDays(1);
                }

                txtDate.Text = "Delivery date: ";
                txtOrderAt.Text = "Ordered At: " + dateOrder.ToLongDateString();
                txtExportAt.Text = "Do you want to release this order on "+ DateTime.Parse(datePicker.Value.ToString()).ToLongDateString();

                btnExport2.Text = "Export";
                txtExporter.Visible = false;
                txtExportAt.Visible = true;
                txtArriveAt.Visible = false;

                fillForm(billID, ordererID, "pending");

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("SQL Exception, try again or check connection");
            }
        }

        

        private void onshippedList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = onshippedList.SelectedCells[0].RowIndex;
            onshippedList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            onshippedList.Rows[rowindex].Selected = true;

            if (unprocessedList.RowCount > 0)
            {
                unprocessedList.SelectionMode = DataGridViewSelectionMode.CellSelect;
                unprocessedList.Rows[0].Cells[0].Selected = true;
            }
            if (havearrivedList.RowCount > 0)
            {
                havearrivedList.SelectionMode = DataGridViewSelectionMode.CellSelect;
                havearrivedList.Rows[0].Cells[0].Selected = true;
            }

            exportId = onshippedList.Rows[rowindex].Cells[0].Value.ToString();
            string billID = onshippedList.Rows[rowindex].Cells[1].Value.ToString();

            try
            {
                conn.Open();
                DateTime dateOrder = DateTime.Parse(onshippedList.Rows[rowindex].Cells[2].Value.ToString());
                DateTime dateSend = DateTime.Parse(onshippedList.Rows[rowindex].Cells[3].Value.ToString());
                txtDate.Text = "Delivery date: ";
                datePicker.Value = dateSend;

                txtOrderAt.Text = "Ordered At: " + dateOrder.ToLongDateString();
                txtExportAt.Text = "Exported At: " + dateSend.ToLongDateString();
                txtArriveAt.Text = "Agent hasn't paid for this bill.";
                string command = "Select TK.HovaTen From PhieuXuatKho XK Left Join Taikhoan TK on TK.Id_Taikhoan = XK.IDNguoiXuat Where XK.SoPhieu = '" + exportId + "'";
                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataReader read = cmd.ExecuteReader();
                string accID = "";
                while (read.Read())
                {
                    accID = read.GetString(0);
                }
                read.Close();
                txtExporter.Text = "Exported by " + accID;

                btnExport2.Text = "Print";
                txtExporter.Visible = true;
                txtExportAt.Visible = true;
                txtArriveAt.Visible = true;

                string ordererID = "Select ID_NguoiDat From PhieuDatHang Where Sophieu ='" + billID + "'";
                cmd = new SqlCommand(ordererID, conn);
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    ordererID = read.GetString(0);
                }
                read.Close();

                fillForm(billID, ordererID, "");

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("SQL Exception, try again or check connection");
            }
        }

        private void havearrivedList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = havearrivedList.SelectedCells[0].RowIndex;
            havearrivedList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            havearrivedList.Rows[rowindex].Selected = true;

            if (unprocessedList.RowCount > 0)
            {
                unprocessedList.SelectionMode = DataGridViewSelectionMode.CellSelect;
                unprocessedList.Rows[0].Cells[0].Selected = true;
            }
            if (onshippedList.RowCount > 0)
            {
                onshippedList.SelectionMode = DataGridViewSelectionMode.CellSelect;
                onshippedList.Rows[0].Cells[0].Selected = true;
            }

            exportId = havearrivedList.Rows[rowindex].Cells[0].Value.ToString();

            try
            {
                conn.Open();

                DateTime dateOrder = DateTime.Parse(havearrivedList.Rows[rowindex].Cells[1].Value.ToString());
                DateTime dateSend = DateTime.Parse(havearrivedList.Rows[rowindex].Cells[2].Value.ToString());
                DateTime dateArrived = DateTime.Parse(havearrivedList.Rows[rowindex].Cells[3].Value.ToString());

                txtDate.Text = "Arrived At: ";
                datePicker.Value = dateArrived;

                txtOrderAt.Text = "Ordered At: " + dateOrder.ToLongDateString();
                txtExportAt.Text = "Exported At: " + dateSend.ToLongDateString();
                txtArriveAt.Text = "Agent paid on " + dateArrived.ToLongDateString() + " over "+ havearrivedList.Rows[rowindex].Cells[4].Value.ToString();

                string command = "Select TK.HovaTen From PhieuXuatKho XK Left Join Taikhoan TK on TK.Id_Taikhoan = XK.IDNguoiXuat  Where XK.SoPhieu = '" + exportId + "'";
                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataReader read = cmd.ExecuteReader();
                string accID = "";
                while (read.Read())
                {
                    accID = read.GetString(0);
                }
                read.Close();
                txtExporter.Text = "Exported by " + accID;

                btnExport2.Text = "Print";
                txtExporter.Visible = true;
                txtExportAt.Visible = true;
                txtArriveAt.Visible = true;


                string billID = "Select SoPhieuDat From PhieuXuatKho Where Sophieu ='" + exportId + "'";
                cmd = new SqlCommand(billID, conn);
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    billID = read.GetString(0);
                }
                read.Close();
                string ordererID = "Select ID_NguoiDat From PhieuDatHang Where Sophieu ='" + billID + "'";
                cmd = new SqlCommand(ordererID, conn);
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    ordererID = read.GetString(0);
                }
                read.Close();



                fillForm(billID, ordererID, "");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // ADDITION FUNCTION
        private void fillForm(string billID, string orderer, string type) {
            fillFormUser(orderer);
            fillFormProduct(billID,type);

            if (type.Equals("pending"))
            {
                datePicker.Enabled = true;
                btnExport.Enabled = true;
            }
            else
            {
                datePicker.Enabled = false;
                btnExport.Enabled = false;
            }
            btnClear.Enabled = true;
            btnShow.Enabled = true;
        }

        private void fillFormUser(string userID)
        {
            String command = "Select HovaTen [Name], Sodienthoai [Phone no], Diachi [Address] ";
            command += "From Taikhoan Where Id_Taikhoan = '" + userID + "'";
            SqlCommand cmd = new SqlCommand(command, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();


            txtOrderer.Text = reader.GetString(0);
            txtHovaTen.Text = "Orderer's name: " + reader.GetString(0);
            txtPhone.Text = reader.GetString(1);
            txtContactNo.Text = "Contact No.: " + reader.GetString(1);
            txtAddress.Text = reader.GetString(2);
            txtOrderAdd.Text = "Address: " + reader.GetString(2);

            reader.Close();
        }

        private void fillFormProduct(string billID,string type)
        {
            // Fill bill info
            string command = "";
            command += "Select DS.MaHangHoa [Product's ID],HH.TenMatHang [Product's Name], Cast( HH.GiaBan as bigint) [Saleprice (k)], HH.DonVi [Unit type], DS.SoLuong [Order's Quantity]";
            if (type.Equals("pending")) 
            { 
                command += ", HH.TonKho[Inventory] "; 
            } else { }

            command += "From PhieuDatHang DH ";
            command += "Left join DanhSachDatHang DS on DH.SoPhieu = DS.MaDanhSach ";
            command += "Left join HangHoa HH on HH.MaHang = DS.MaHangHoa ";
            command += "Where DH.SoPhieu = '"+ billID +"'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command, conn);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            billInfo.DataSource = ds.Tables[0];

            billInfo.Columns[0].Width = 150;
            billInfo.Columns[2].Width = 150;
            billInfo.Columns[3].Width = 100;
            billInfo.Columns[4].Width = 150;

            billInfo.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            billInfo.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            billInfo.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            billInfo.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            billInfo.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            billInfo.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            billInfo.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (type.Equals("pending"))
            {
                billInfo.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            else { }

            for (int i = 0; i < billInfo.ColumnCount; i++)
            {
                billInfo.Columns[i].HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                billInfo.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Fill Total Price. Max: 2^63 - 1 = 9223372036854775807
            command = "";
            command += "Select Cast( (Sum(DS.SoLuong*HH.GiaBan)) as bigint)";
            command += "From PhieuDatHang DH ";
            command += "Left join DanhSachDatHang DS on DH.SoPhieu = DS.MaDanhSach ";
            command += "Left join HangHoa HH on HH.MaHang = DS.MaHangHoa ";
            command += "Where DH.SoPhieu = '" + billID +"'";

            SqlCommand cmd = new SqlCommand(command,conn);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            txtTotal.Text = reader[0].ToString()+" k";
            infoTotal.Text = "Total: " + reader[0].ToString() + " k";
            reader.Close();

            billInfo.ClearSelection();
        }

        private void clearForm()
        {
            txtOrderer.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtTotal.Text = "";
            datePicker.Value = DateTime.Parse("01-01-2001"); // mm-dd-yyyy
            datePicker.Enabled = false;

            btnShow.Enabled = false;
            btnClear.Enabled = false;
            btnExport.Enabled = false;

            txtHovaTen.Visible = true;
            txtOrderAdd.Visible = true;

            txtOrderAt.Text = "Ordered At: ";
            txtExportAt.Text = "Exported At: ";
            txtArriveAt.Text = "   Arrived At: ";
            txtOrderAt.Visible = true;
            txtExportAt.Visible = false;
            txtArriveAt.Visible = false;

            btnExport2.Visible = true;
            txtExporter.Visible = false;
            panelInfo.Visible = false;
            billInfo.Refresh();

            unprocessedList.ClearSelection();
            onshippedList.ClearSelection();
            havearrivedList.ClearSelection();

            if (unprocessedList.RowCount > 0)
            {
                unprocessedList.SelectionMode = DataGridViewSelectionMode.CellSelect;
                unprocessedList.Rows[0].Cells[0].Selected = true;
            }
            if (onshippedList.RowCount > 0)
            {
                onshippedList.SelectionMode = DataGridViewSelectionMode.CellSelect;
                onshippedList.Rows[0].Cells[0].Selected = true;
            }
            if (havearrivedList.RowCount > 0)
            {
                havearrivedList.SelectionMode = DataGridViewSelectionMode.CellSelect;
                havearrivedList.Rows[0].Cells[0].Selected = true;
            }
            
        }

        private void reloadPage()
        {
            Xuat reload = new Xuat(user);
            this.Hide();
            reload.ShowDialog();
            this.Close();
        }

        private void reload()
        {
            try
            {
                conn.Open();
                DataTable clear = new DataTable();
                unprocessedList.DataSource = clear;
                onshippedList.DataSource = clear;
                havearrivedList.DataSource = clear;

                loadUnprocessed();
                loadOnBeingShipped();
                loadHaveArrived();

                clearForm();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = true;
            billInfo.Rows[0].Cells[0].Selected = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string date = datePicker.Value.Date + "";
            string billId = unprocessedList.SelectedRows[0].Cells[0].Value.ToString();

            try
            {
                conn.Open();
                
                string check = "Exec dbo.checkSoLuongHangHoa '" + billId + "'";
                SqlCommand check_cmd = new SqlCommand(check, conn);
                SqlDataReader check_reader = check_cmd.ExecuteReader();

                check_reader.Read();

                String check_String = check_reader.GetString(0);

                check_reader.Close();
                conn.Close();


                if (check_String.Equals("Enough"))
                {
                    conn.Open();
                    int rowindex = unprocessedList.SelectedCells[0].RowIndex;
                    DateTime dateSend = datePicker.Value.Date;
                    DateTime dateOrder = DateTime.Parse(unprocessedList.Rows[rowindex].Cells[2].Value.ToString()).Date;
                    if (dateSend < dateOrder)
                    {
                        notifyDateError.Visible = true;
                        notifyDateError.ShowBalloonTip(50);
                        notifySuccess.Visible = false;
                        notifyNotEnough.Visible = false;
                        conn.Close();
                    }
                    else
                    {
                        string command = "Select Id_Taikhoan From Taikhoan Where Tendangnhap = '" + user + "'";
                        SqlCommand cmd = new SqlCommand(command, conn);
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();

                        string accid = reader.GetString(0);

                        reader.Close();
                        command = "Exec dbo.themPhieuXuatKho '" + billId + "','" + accid + "','" + date + "'";
                        cmd = new SqlCommand(command, conn);
                        reader = cmd.ExecuteReader();

                        notifySuccess.Visible = true;
                        notifySuccess.ShowBalloonTip(50, "Export Success", "Bill: " + billId + " has exported", ToolTipIcon.Info);
                        notifyNotEnough.Visible = false;
                        notifyDateError.Visible = false;

                        reader.Close();


                        conn.Close();
                        reload();
                    }
                }
                else
                {
                    String[] listNotEnough = check_String.Split(':');
                    String listItem = listNotEnough[1];
                    String[] items = listItem.Split(',');
                    notifyNotEnough.BalloonTipText = "";

                    conn.Open();
                    for (int i=0; i < items.Length; i++)
                    {
                        String[] info = items[i].Split('-');
                        String tmp = info[0] + ". Missing: "+info[1]+" items.\n";
                        notifyNotEnough.BalloonTipText += tmp;
                    }
                    conn.Close();

                    notifyNotEnough.Visible = true;
                    notifyNotEnough.ShowBalloonTip(50);
                    notifySuccess.Visible = false;
                    notifyDateError.Visible = false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                reloadPage();
            } 
        }

        private void btnExport2_Click(object sender, EventArgs e)
        {
            if(btnExport.Enabled == true)
            {
                btnExport_Click(sender, e);
            }
            else
            {
                ExportInfo print = new ExportInfo(exportId,conn);
                print.ShowDialog();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMain_kt back = new FormMain_kt(user);
            this.Hide();
            back.ShowDialog();
            this.Close();
        }

        private void btnBillExit_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            billInfo.Refresh();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reload();
        }
    }
}

using Nhom01.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nhom01.DAL
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }
        public List<RoomDTO> Loadhocki(int masv)
        {
            List<RoomDTO> tableList = new List<RoomDTO>();

            DataTable data = DataP.Instance.ExcuteQuery(@"SELECT DISTINCT HOCKY FROM LOPHOCPHAN LHP JOIN LOPHOC LP ON LHP.MALOP = LP.MALOP
JOIN MONHOC MH ON MH.MAMONHOC = LHP.MAMONHOC JOIN SINHVIEN SV ON SV.MALOP = LP.MALOP WHERE SV.MASV = "+masv+"");

            foreach (DataRow item in data.Rows)
            {
                RoomDTO table = new RoomDTO(item);
                tableList.Add(table);
            }

            return tableList;
        }
        public List<menu> LoadCategory2()
        {
            List<menu> tableList = new List<menu>();

            DataTable data = DataP.Instance.ExcuteQuery("SELECT DISTINCT TenMonHoc FROM Monhoc");

            foreach (DataRow item in data.Rows)
            {
                menu table = new menu(item);
                tableList.Add(table);
            }

            return tableList;
        }
        public bool InserCategory(int masv, int mamon, double chuyencan, double dhs1, double dhs2l1, double dhs2l2, double kq, double diemthi, double diemhocphan)
        {
            string query = "EXEC UPIN_SCORE @MASV , @MAMONHOC , @DIEMCHUYENCAN , @DIEMHESO1 , @DIEMHESO21 , @DIEMHESO22 , @DIEMQUATRINH , @DIEMTHI , @DIEMHOCPHAN";
            int result = DataP.Instance.ExcuteNonQuery(query, new object[] { masv, mamon, chuyencan, dhs1, dhs2l1, dhs2l2, kq, diemthi, diemhocphan });
            return result > 0;
        }
        public bool UpdateCategory(int ID,string name, string type, int numMedicine, DateTime dateofmanufuture, DateTime dateexpirationDay, int numprice, string more)
        {
            string query = "EXEC UPDATE_MEDICINE @ID , @MEDICINE_NAME , @TYPE_MEDICINE , @NUMBER_MEDICINE , @DAY_OF_MANUFUTURE_MEDICINE , @EXPIRATION_DAY_MEDICINE , @PRICE_MEDICINE , @MORE_MEDICINE";
            int result = DataP.Instance.ExcuteNonQuery(query, new object[] {ID, name, type, numMedicine, dateofmanufuture, dateexpirationDay, numprice, more });
            return result > 0;
        }
       
    }
}

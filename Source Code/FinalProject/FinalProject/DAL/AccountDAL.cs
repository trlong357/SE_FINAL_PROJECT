using Nhom01.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nhom01.DAL
{
   
    public class AccountDAL
    {
        private static AccountDAL instance;

        public static AccountDAL Instance { get { if (instance == null) instance = new AccountDAL(); return AccountDAL.instance; } private set => instance = value; }

        private AccountDAL() { }
        public bool login(string user, string pass)
        {
            //store
            string query = @"EXEC LOGIN @USERNAME , @PASSWORD";
            DataTable result = DataP.Instance.ExcuteQuery(query,new object[] {user,pass});
            return result.Rows.Count > 0;
        }
        public ACCOUNTDTO getusername(string user)
        {
            string query = "SELECT * FROM USER_USE WHERE USERNAME = '"+ user + "' ";
            DataTable data = DataP.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new ACCOUNTDTO(item);
            }
            return null;
        }
        public menu gettinchi(string cbmonhoc)
        {
            string query = @"SELECT SOTINCHI, mamonhoc from MONHOC where tenmonhoc = N'"+cbmonhoc+"'";
            DataTable data = DataP.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                    return new menu(item);
            }
            return null;
        }
        
        public GUEST GetSumTinChi(int masv, int hocky)
        {
            string query = @"SELECT SUM(MH.SOTINCHI) as tinchitong FROM LOPHOC LH JOIN SINHVIEN SV 
		    ON LH.MALOP = SV.MALOP join LOPHOCPHAN LHP 
		    on LHP.MALOP = LH.MALOP JOIN MONHOC MH 
		    ON LHP.MAMONHOC = MH.MAMONHOC JOIN DIEM D 
		    ON D.MASV = SV.MASV and D.MAMONHOC = MH.MAMONHOC WHERE SV.MASV = "+masv+" AND HOCKY = "+hocky+"";
            DataTable data = DataP.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new GUEST(item);
            }
            return null;
        }
        public MoreBillDTO GetSumDiem(int masv, int hocky)
        {
            string query = @"SELECT SUM(SOTINCHI*DIEMHOCPHAN) AS TONG FROM LOPHOC LH JOIN SINHVIEN SV 
		    ON LH.MALOP = SV.MALOP join LOPHOCPHAN LHP 
		    on LHP.MALOP = LH.MALOP JOIN MONHOC MH 
		    ON LHP.MAMONHOC = MH.MAMONHOC JOIN DIEM D 
		    ON D.MASV = SV.MASV and D.MAMONHOC = MH.MAMONHOC WHERE SV.MASV = " + masv + " AND HOCKY = " + hocky + "";
            DataTable data = DataP.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new MoreBillDTO(item);
            }
            return null;
        }
       
        public bool Changepass(string user, string pass)
        {
            string query = "UPDATE USER_USE SET PASSWORD = N'" + pass+"' WHERE USERNAME = N'"+user+"'";
            int result  = DataP.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool Adduser(string user, string pass, int access)
        {
            string query = "INSERT ACCOUNT (USERNAME, PASSWORDS, ACCESS) VALUES(N'"+ user + "','"+pass+"',"+access+")";
            int result = DataP.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}

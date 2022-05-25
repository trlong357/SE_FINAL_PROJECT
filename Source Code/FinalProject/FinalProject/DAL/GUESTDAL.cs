using Nhom01.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nhom01.DAL
{
   public class GUESTDAL
   {
        private static GUESTDAL instance;
        public static GUESTDAL Instance
        {
            get { if (instance == null) instance = new GUESTDAL(); return GUESTDAL.instance; }
            private set { GUESTDAL.instance = value; }
        }
        private GUESTDAL() { }
        public bool InserGuest(string fullname, string username, string password, string sex, int permision)
        {
            string query = "EXEC INSERT_USER @FULLNAME , @USERNAME , @PASSWORD , @SEX , @PERMISION";
            int result = DataP.Instance.ExcuteNonQuery(query, new object[] { fullname, username, password, sex, permision });
            return result > 0;
        }
        public bool UpdateGuest(string fullname, string username, string sex, int permision)
        {
            string query = "EXEC UPDATE_USER @FULLNAME , @USERNAME , @SEX , @PERMISION";
            int result = DataP.Instance.ExcuteNonQuery(query, new object[] { fullname, username, sex, permision });
            return result > 0;
        }
        public bool DelGuest(string username)
        {
            string query = "EXEC DEL_USER @USERNAME";
            int result = DataP.Instance.ExcuteNonQuery(query, new object[] { username});
            return result > 0;
        }
        public GUEST getpass(string username)
        {
            string query = $"SELECT PASSWORD FROM USER_USE WHERE USERNAME = '"+username+"'";
            DataTable result = DataP.Instance.ExcuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
               return new GUEST(item);
            }
            return null;
        }

    }
}

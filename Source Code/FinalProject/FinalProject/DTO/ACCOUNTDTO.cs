using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nhom01.DTO
{
   public class ACCOUNTDTO
    {
        string fullname;
        string username;
        string password;
        string sex;
        int access;
        public ACCOUNTDTO(string fullname,string username, string password, string sex, int access)
        {
            this.Fullname = fullname;
            this.Username = username;
            this.Password = password;
            this.Sex = sex;
            this.access = access;

        }
        public ACCOUNTDTO(DataRow row)
        {
            this.fullname = row["FULLNAME"].ToString(); 
            this.Username = row["USERNAME"].ToString();
            this.Sex = row["SEX"].ToString();
            this.access = (int)row["PERMISION"];
        }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Fullname { get => fullname; set => fullname = value; }
       
        public int Access { get => access; set => access = value; }
        public string Sex { get => sex; set => sex = value; }
    }
}

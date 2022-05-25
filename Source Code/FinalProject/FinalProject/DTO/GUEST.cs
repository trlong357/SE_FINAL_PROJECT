using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nhom01.DTO
{
   public class GUEST
    {
        private int tinchi;
        public GUEST(int tinchi)
        {
            this.Tinchi = tinchi;
        }
        public GUEST(DataRow row)
        {
             this.Tinchi = (int)row["tinchitong"];
        }

        public int Tinchi { get => tinchi; set => tinchi = value; }
    }
}

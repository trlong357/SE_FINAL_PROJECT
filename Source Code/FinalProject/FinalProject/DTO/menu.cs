using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nhom01.DTO
{
    public class menu
    {
        int tinchi;
        int mamon;
        public menu(DataRow datarow)
        {
            this.mamon = Convert.ToInt32(datarow["mamonhoc"]);
            this.tinchi = Convert.ToInt32(datarow["SoTinChi"]);
        }
        public int Tinchi { get => tinchi; set => tinchi = value; }
        public int Mamon { get => mamon; set => mamon = value; }
    }
}

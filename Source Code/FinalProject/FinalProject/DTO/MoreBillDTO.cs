using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nhom01.DTO
{
   public class MoreBillDTO
    {
        decimal tongdiem;
        public MoreBillDTO(decimal diem)
        {
            this.Tongdiem = diem;
           
        }

        public MoreBillDTO(DataRow row)
        {
            this.Tongdiem = (decimal)row["TONG"];
           
        }

        public decimal Tongdiem { get => tongdiem; set => tongdiem = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nhom01.DTO
{
    public class RoomDTO
    {
        int type_medicine;
        public RoomDTO(DataRow datarow)
        {
            this.Type_medicine = (int)datarow["HOCKY"];
        }
        public int Type_medicine { get => type_medicine; set => type_medicine = value; }
    }
}

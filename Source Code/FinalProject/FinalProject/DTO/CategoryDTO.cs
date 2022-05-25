using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuoc.DTO
{
    internal class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int num { get; set; }
        public decimal price { get; set; }
        public string description()
        {
            return string.Format($"{name} với số lượng {num} và giá {price*num}");
        }

    }
}

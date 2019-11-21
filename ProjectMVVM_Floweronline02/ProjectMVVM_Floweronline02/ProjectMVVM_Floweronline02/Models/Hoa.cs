using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace ProjectMVVM_Floweronline02.Models
{
    public class Hoa
    {
        [PrimaryKey, AutoIncrement]
        public int Mahoa { get; set; }
        public int Loaihoa { get; set; }
        public string Tenhoa { get; set; }
        public string Hinh { get; set; }
        public string Mota { get; set; }
        public double Gia { get; set; }
    }
}

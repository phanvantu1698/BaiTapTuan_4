using System;
using System.Collections.Generic;
using System.Text;
using ProjectMVVM_Floweronline02.Helpers;
using ProjectMVVM_Floweronline02.Interface;
using ProjectMVVM_Floweronline02.Models;
using System.Collections.ObjectModel;
namespace ProjectMVVM_Floweronline02.Repository
{


    public class LoaihoaRepository : ILoaihoaRepository
    {
        Database db;
        public LoaihoaRepository()
        {
            db = new Database();

        }
        public bool Delete(Loaihoa h)
        {
            return db.DeleteLoaihoa(h);
        }
        public Loaihoa GetLoaihoaByid(int Maloai)
        {
            return db.GetLoaihoaByid(Maloai);
        }
        public ObservableCollection<Loaihoa> GetLoaihoas()
        {

            return new ObservableCollection<Loaihoa>(db.GetLoaihoas());

        }
        public bool Insert(Loaihoa h)
        {
            return db.InsertLoaihoa(h);
        }
        public bool Update(Loaihoa h)
        {
            return db.UpdateLoaihoa(h);
        }
    }

}

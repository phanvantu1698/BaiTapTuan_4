using System;
using System.Collections.Generic;
using System.Text;
using ProjectMVVM_Floweronline02.Models;
using System.Collections.ObjectModel;
namespace ProjectMVVM_Floweronline02.Interface
{
    public interface ILoaihoaRepository
    {
        ObservableCollection<Loaihoa> GetLoaihoas();
        Loaihoa GetLoaihoaByid(int Maloai);
        bool Insert(Loaihoa h);
        bool Update(Loaihoa h);
        bool Delete(Loaihoa h);


    }
}

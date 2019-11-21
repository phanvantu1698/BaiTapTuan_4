using ProjectMVVM_Floweronline02.Interface;
using ProjectMVVM_Floweronline02.Models;
using ProjectMVVM_Floweronline02.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
namespace ProjectMVVM_Floweronline02.ViewModels
{
    public class LoaihoaViewModel : INotifyPropertyChanged
    {
        private Loaihoa loaihoa;
        public ILoaihoaRepository loaihoaRepository;
        public ICommand AddLoaiHoa { get; private set; }
        public ICommand UpdateLoaiHoa { get; private set; }
        public ICommand DeleteLoaiHoa { get; private set; }
        public LoaihoaViewModel()
        {
            loaihoaRepository = new LoaihoaRepository();
            Loadloaihao();
            AddLoaiHoa = new Command(Insert);
            UpdateLoaiHoa = new Command(Update, CanExe);
            DeleteLoaiHoa = new Command(Delete, CanExe);
            loaihoa = new Loaihoa();
        }
        private void Delete(object obj)
        {
            loaihoaRepository.Delete(Loaihoa);
            Loadloaihao();
        }
        private bool CanExe(object arg)
        {
            if (Loaihoa == null || Loaihoa.Maloai == 0)
                return false;
            else
                return true;
        }
        private void Update(object obj)
        {
            loaihoaRepository.Update(Loaihoa);
            Loadloaihao();
        }
        public Loaihoa Loaihoa
        {
            get { return loaihoa; }
            set
            {
                loaihoa = value;
                RaisePropertyChanged("Loaihoa");
                ((Command)UpdateLoaiHoa).ChangeCanExecute();
            }
        }
        private void Insert(object obj)
        {
            loaihoaRepository.Insert(loaihoa);
            Loadloaihao();
        }
        public int Maloai
        {
            get { return loaihoa.Maloai; }
            set
            {
                loaihoa.Maloai = value;
                RaisePropertyChanged("Maloai");
            }
        }
        public string Tenloai
        {
            get { return loaihoa.Tenloai; }
            set
            {
                loaihoa.Tenloai = value;
                RaisePropertyChanged("Tenloai");

            }
        }
        ObservableCollection<Loaihoa> loaihoalist;
        public ObservableCollection<Loaihoa> Loaihoalist
        {
            get { return loaihoalist; }
            set
            {
                loaihoalist = value;
                RaisePropertyChanged("Loaihoalist");
            }
        }
        void Loadloaihao()
        {
            Loaihoalist = loaihoaRepository.GetLoaihoas();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}

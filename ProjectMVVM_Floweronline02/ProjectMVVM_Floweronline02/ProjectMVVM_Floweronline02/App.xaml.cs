using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ProjectMVVM_Floweronline02.Views;

namespace ProjectMVVM_Floweronline02
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

         
            MainPage = new PageInsertLoaihoa();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

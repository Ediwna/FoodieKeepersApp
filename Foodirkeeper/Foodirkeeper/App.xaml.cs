using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Foodirkeeper
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage()); // 创建根页面
            //MainPage = new Page1();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

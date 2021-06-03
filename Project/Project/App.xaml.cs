using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new MainPage();
            //MainPage = new Project.FirstPage();
            //MainPage = new FirstPage();
           MainPage = new NavigationPage(new Project.FirstPage());
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


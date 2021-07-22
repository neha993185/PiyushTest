using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SMS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Piyush branch
            MainPage = new MainPage();

        }

        protected override void OnStart()
        {
            //Piyush start
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

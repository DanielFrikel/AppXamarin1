using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTest.Models;
using Xamarin.Forms;

namespace AppTest
{
    public partial class MainPage : ContentPage
    {
        public string Txtusername { get; set; }
        public string Txtpassword { get; set; }
        public MainPage()
        {
            InitializeComponent();

            //Enlaza la pagina MainPage al ViewModel Main (vmMain)            
            BindingContext = new vmMain(Navigation);
        }

        //private void irInicio(object sender, EventArgs e)
        //{            
        //    User user = new User()
        //    {
        //        username = Txtusername.ToString(),
        //        password = Txtpassword.ToString()
        //    };
            
        //    Navigation.PushAsync(new Inicio(user));            
        //}
        private void irRegistrar(object sender, EventArgs e)
        {
            User user = new User()
            {
                username = "btnRegistrar",
                password = "0"
            };
            Navigation.PushAsync(new Inicio(user));
        }
    }
}

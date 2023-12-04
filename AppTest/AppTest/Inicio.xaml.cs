using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTest;
using AppTest.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio(User user)
        {
            //Content = new Label
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Text = "Hello World"
            //};

            InitializeComponent();
            //Navegar a la pagina MainPage.xaml
            //Navigation.PushAsync(new MainPage());
            DisplayAlert("Bienvenido " + user.username, "Has ingresado a la pagina de Inicio", "Aceptar");
            //FullScreen            
        }


        private void Regresar(object sender, EventArgs e)
        {
            //Title, Message, ButtonText
            //DisplayAlert("Titulo", "Hello World", "Aceptar");
            Navigation.PopAsync();
        }
    }
}
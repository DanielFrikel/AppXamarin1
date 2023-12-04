using AppTest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppTest
{
    public class vmMain : INotifyPropertyChanged
    {
        public INavigation Navigation;
        string _txtUsername, _txtPassword;
        public vmMain(INavigation navigation)
        {
            Navigation = navigation;
        }

        public string txtUsername
        {
            get { return _txtUsername; }
            set
            {
                if (_txtUsername != value)
                {
                    _txtUsername = value;
                    OnPropertyChanged(nameof(txtUsername));
                }
            }
        }       
        public string txtPassword
        {
            get { return _txtPassword; }
            set
            {
                if (_txtPassword != value)
                {
                    _txtPassword = value;
                    OnPropertyChanged(nameof(txtPassword));
                }
            }
        }

        public async Task iniciarSesion()
        {
            //await DisplayAlert("Titulo", Mensaje, "OK");
            User user = new User()
            {
                username = txtUsername,
                password = txtPassword
            };

            await Navigation.PushAsync(new Inicio(user));
        }

        public void Funcionsita()
        {
            //User user = new User()
            //{
            //    username = txtUsername,
            //    password = txtPassword
            //};

            //Navigation.PushAsync(new Inicio(user));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand iniciarSesionCommand => new Command(async () => await iniciarSesion());
        public ICommand FuncionsitaCommand => new Command(Funcionsita);
    }
}

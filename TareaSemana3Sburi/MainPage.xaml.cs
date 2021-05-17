using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TareaSemana3Sburi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                await DisplayAlert("Error", "Ingrese usuario", "Aceptar");
                txtUser.Focus();
                return;

            }

            if (string.IsNullOrEmpty(txtPass.Text))
            {
                await DisplayAlert("Error", "Ingrese contraseña", "Aceptar");
                txtPass.Focus();
                return;
            }

            if (txtUser.Text == "estudiante2021" && txtPass.Text == "uisrael2021")
            {
                string usuario = txtUser.Text;
                string clave = txtPass.Text;


                await Navigation.PushAsync(new Notas(usuario, clave));


            }
            else
            {
                await DisplayAlert("Error", "Usuario o clave incorrecta", "Aceptar");
            }

        }
    }
}

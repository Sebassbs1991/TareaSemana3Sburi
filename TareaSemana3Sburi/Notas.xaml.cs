using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaSemana3Sburi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Notas : ContentPage
    {
        double dato1;
        double dato2;
        double dato3;
        double dato4;
        double calcular;
        double calcular2;
        double notaFinal;

        public Notas(string usuario, string clave)
        {
            InitializeComponent();

            lblUser.Text = $"Usuario Conectado: {usuario}";
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                dato1 = Convert.ToDouble(txtDato1.Text);
                dato2 = Convert.ToDouble(txtDato2.Text);

                calcular = (dato1 * 0.3) + (dato2 * 0.2);
                txtResultado.Text = calcular.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias");
            }
        }

        private void btnCalcular2_Clicked(object sender, EventArgs e)
        {
            try
            {
                dato3 = Convert.ToDouble(txtDato3.Text);
                dato4 = Convert.ToDouble(txtDato4.Text);

                calcular2 = (dato3 * 0.3) + (dato4 * 0.2);
                txtResultado2.Text = calcular2.ToString();


                notaFinal = calcular + calcular2;
                txtNotaFinal.Text = notaFinal.ToString();

                if (notaFinal >= 7)
                {
                    DisplayAlert("Alerta", "APROBADO", "Gracias");
                }
                else if (notaFinal < 7 && notaFinal > 5)
                {
                    DisplayAlert("Alerta", "COMPLEMENTARIO", "Gracias");
                }
                else
                {
                    DisplayAlert("Alerta", "REPROBADO", "Gracias");
                }





            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias");
            }

        }
    }
}
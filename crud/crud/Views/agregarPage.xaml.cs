using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace crud
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class agregar : ContentPage
    {
        public agregar()
        {
            InitializeComponent();
        }

        private async void btnguardar_Clicked(object sender, EventArgs e)
        {
            string nombres = (nombre_usuario.Text);
            string telefonos = (telefono.Text);
            string correo = (correo_electronico.Text);

            HttpClient client = new HttpClient();
            usuarios agregar = new usuarios();
            agregar.nombre_usuario = nombres;
            agregar.telefono = telefonos;
            agregar.correo_electronico = correo;

            String jsonAgregar = JsonConvert.SerializeObject(agregar);
            var content = new StringContent(jsonAgregar, Encoding.UTF8, "application/json");
            string url = "http://localhost:3000/api/crudxamarin/agregar";
            var json = await client.PostAsync(url, content);
            await Navigation.PushAsync(new inicio());

        }
    }
}
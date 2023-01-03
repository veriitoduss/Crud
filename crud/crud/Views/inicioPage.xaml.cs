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
    public partial class inicio : ContentPage
    {
        public inicio()
        {
            InitializeComponent();
            Getusuarios();
        }

        private async void Getusuarios()
        {
            HttpClient client = new HttpClient();
            var usuario = await client.GetStringAsync("http://localhost:3000/api/crudxamarin/usuarios");
            var guardausuario = JsonConvert.DeserializeObject<List<usuarios>>(usuario);
            listarusuarios.ItemsSource = guardausuario;
        }

        private async void btnagregar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new agregar());
        }

        
    }
}
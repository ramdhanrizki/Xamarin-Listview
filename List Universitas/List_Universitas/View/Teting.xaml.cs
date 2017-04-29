using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace List_Universitas.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Teting : ContentPage
    {
        public Teting()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(true);

        }
    }
}

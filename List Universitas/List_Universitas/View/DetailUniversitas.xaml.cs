using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using List_Universitas.Model;
namespace List_Universitas.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailUniversitas : ContentPage
    {
        public DetailUniversitas(ModelUniversitas item)
        {
            InitializeComponent();
            this.BindingContext = item; 
            btnBack.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync(true);
            };
        }
    }
}

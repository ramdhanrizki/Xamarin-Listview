using List_Universitas.Model;
using List_Universitas.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace List_Universitas.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //gambar.Source = ImageSource.FromFile("ITB.png");
            VMUniversitas vmuniversitas = new VMUniversitas();
            BindingContext = vmuniversitas;
            
            listView.ItemTapped += async (sender, e) => {
                //if (e.SelectedItem == null) return; 
                ModelUniversitas univ = (ModelUniversitas)e.Item;
                await Task.Yield();
                await Navigation.PushAsync(new DetailUniversitas(univ));
                ((ListView)sender).SelectedItem = null;
            };
        }
    }


}

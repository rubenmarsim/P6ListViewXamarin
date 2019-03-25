using ListView_XamarinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListView_XamarinForms.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Personatge : ContentPage
	{
        public Personatge(Monkey item)
        {
            InitializeComponent();
            Nombre.Text = item.Name;
            BackgroundColor = Color.Black;
            Foto.Source = item.Image;
            Desc.Text = item.Details;
            Desc.TextColor = Color.White;
            Nombre.TextColor = Color.White;
            Nombre.FontSize = 40;

        }
        public void BackButtonPressedEventsArgs(object sender, SelectedItemChangedEventArgs e)
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
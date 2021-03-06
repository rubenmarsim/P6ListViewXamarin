﻿using ListView_XamarinForms.Models;
using ListView_XamarinForms.ViewModels;
using Xamarin.Forms;

namespace ListView_XamarinForms.Views
{
    public partial class ImageCellView : ContentPage
    {
        private object Parameter { get; set; }

        public ImageCellView(object parameter)
        {
            InitializeComponent();

            BindingContext = App.Locator.CustomCellViewModel;

            Parameter = parameter;
            Llista.ItemSelected += Llista_ItemSelected;
        }
        public void Llista_ItemSelected(object sende, SelectedItemChangedEventArgs e)
        {
            Navigation.PushModalAsync(new Personatge((Monkey)e.SelectedItem));
        }


        protected override void OnAppearing()
        {
            var viewModel = BindingContext as CustomCellViewModel;
            if (viewModel != null) viewModel.OnAppearing(Parameter);
        }

        protected override void OnDisappearing()
        {
            var viewModel = BindingContext as CustomCellViewModel;
            if (viewModel != null) viewModel.OnDisappearing();
        }

        private void onImageCitizenReporterTapped(object sender, System.EventArgs e)
        {

        }
    }
}

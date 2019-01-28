using ListView_XamarinForms.ViewModels;
using Xamarin.Forms;

namespace ListView_XamarinForms.Views
{
    public partial class CustomCellView : ContentPage
    {
        private object Parameter { get; set; }

        public CustomCellView(object parameter)
        {
            InitializeComponent();

            BindingContext = App.Locator.CustomCellViewModel;

            Parameter = parameter;
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
    }
}

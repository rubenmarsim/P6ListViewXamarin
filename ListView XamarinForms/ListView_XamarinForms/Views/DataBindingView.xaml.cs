using ListView_XamarinForms.ViewModels;
using Xamarin.Forms;

namespace ListView_XamarinForms.Views
{
    public partial class DataBindingView : ContentPage
    {
        private object Parameter { get; set; }

        public DataBindingView(object parameter)
        {
            InitializeComponent();

            BindingContext = App.Locator.DataBindingViewModel;

            Parameter = parameter;
        }

        protected override void OnAppearing()
        {
            var viewModel = BindingContext as DataBindingViewModel;
            if (viewModel != null) viewModel.OnAppearing(Parameter);
        }

        protected override void OnDisappearing()
        {
            var viewModel = BindingContext as DataBindingViewModel;
            if (viewModel != null) viewModel.OnDisappearing();
        }
    }
}

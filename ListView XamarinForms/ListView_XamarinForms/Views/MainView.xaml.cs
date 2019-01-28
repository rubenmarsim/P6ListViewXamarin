using ListView_XamarinForms.ViewModels;
using Xamarin.Forms;

namespace ListView_XamarinForms.Views
{
    public partial class MainView : ContentPage
    {
        private object Parameter { get; set; }

        public MainView(object parameter)
        {
            InitializeComponent();

            BindingContext = App.Locator.MainViewModel;

            Parameter = parameter;
        }

        protected override void OnAppearing()
        {
            var viewModel = BindingContext as MainViewModel;
            if (viewModel != null) viewModel.OnAppearing(Parameter);
        }

        protected override void OnDisappearing()
        {
            var viewModel = BindingContext as MainViewModel;
            if (viewModel != null) viewModel.OnDisappearing();
        }
    }
}

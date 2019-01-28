using ListView_XamarinForms.ViewModels;
using Xamarin.Forms;

namespace ListView_XamarinForms.Views
{
    public partial class PerformanceView : ContentPage
    {
        private object Parameter { get; set; }

        public PerformanceView(object parameter)
        {
            InitializeComponent();

            BindingContext = App.Locator.PerformanceViewModel;

            Parameter = parameter;
        }

        protected override void OnAppearing()
        {
            var viewModel = BindingContext as PerformanceViewModel;
            if (viewModel != null) viewModel.OnAppearing(Parameter);
        }

        protected override void OnDisappearing()
        {
            var viewModel = BindingContext as PerformanceViewModel;
            if (viewModel != null) viewModel.OnDisappearing();
        }
    }
}

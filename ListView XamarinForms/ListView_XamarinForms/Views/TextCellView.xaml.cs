using ListView_XamarinForms.ViewModels;
using Xamarin.Forms;

namespace ListView_XamarinForms.Views
{
    public partial class TextCellView : ContentPage
    {
        private object Parameter { get; set; }

        public TextCellView(object parameter)
        {
            InitializeComponent();

            BindingContext = App.Locator.TextCellViewModel;

            Parameter = parameter;
        }

        protected override void OnAppearing()
        {
            var viewModel = BindingContext as TextCellViewModel;
            if (viewModel != null) viewModel.OnAppearing(Parameter);
        }

        protected override void OnDisappearing()
        {
            var viewModel = BindingContext as TextCellViewModel;
            if (viewModel != null) viewModel.OnDisappearing();
        }
    }
}
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

            BindingContext = App.Locator.ImageCellViewModel;

            Parameter = parameter;
        }

        protected override void OnAppearing()
        {
            var viewModel = BindingContext as ImageCellViewModel;
            if (viewModel != null) viewModel.OnAppearing(Parameter);
        }

        protected override void OnDisappearing()
        {
            var viewModel = BindingContext as ImageCellViewModel;
            if (viewModel != null) viewModel.OnDisappearing();
        }
    }
}

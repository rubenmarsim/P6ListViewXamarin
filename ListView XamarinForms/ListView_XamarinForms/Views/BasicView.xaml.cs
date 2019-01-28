using ListView_XamarinForms.ViewModels;
using Xamarin.Forms;

namespace ListView_XamarinForms.Views
{
    public partial class BasicView : ContentPage
    {
        private object Parameter { get; set; }

        private string[] Monkeys = 
            {
              "Baboon",
              "Capuchin Monkey",
              "Blue Monkey",
              "Squirrel Monkey",
              "Golden Lion Tamarin",
              "Howler Monkey",
              "Japanese Macaque",
              "Mandrill",
              "mononucleosis"
            };

        public BasicView(object parameter)
        {
            InitializeComponent();

            BindingContext = App.Locator.BasicViewModel;

            Parameter = parameter;
        }

        protected override void OnAppearing()
        {
            var viewModel = BindingContext as BasicViewModel;
            if (viewModel != null) viewModel.OnAppearing(Parameter);

            BasicListView.ItemsSource = Monkeys;
        }

        protected override void OnDisappearing()
        {
            var viewModel = BindingContext as BasicViewModel;
            if (viewModel != null) viewModel.OnDisappearing();
        }
    }
}

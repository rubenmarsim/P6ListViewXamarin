using Microsoft.Practices.Unity;
using ListView_XamarinForms.Services.Navigation;

namespace ListView_XamarinForms.ViewModels.Base
{
    public class ViewModelLocator
    {
        readonly IUnityContainer _container;

        public ViewModelLocator()
        {
            _container = new UnityContainer();

            // ViewModels
            _container.RegisterType<BasicViewModel>();
            _container.RegisterType<CustomCellViewModel>();
            _container.RegisterType<DataBindingViewModel>();
            _container.RegisterType<ImageCellViewModel>();
            _container.RegisterType<MainViewModel>();
            _container.RegisterType<PerformanceViewModel>();
            _container.RegisterType<TextCellViewModel>();

            // Services     
            _container.RegisterType<INavigationService, NavigationService>();
        }

        public BasicViewModel BasicViewModel
        {
            get { return _container.Resolve<BasicViewModel>(); }
        }

        public CustomCellViewModel CustomCellViewModel
        {
            get { return _container.Resolve<CustomCellViewModel>(); }
        }

        public DataBindingViewModel DataBindingViewModel
        {
            get { return _container.Resolve<DataBindingViewModel>(); }
        }

        public ImageCellViewModel ImageCellViewModel
        {
            get { return _container.Resolve<ImageCellViewModel>(); }
        }

        public MainViewModel MainViewModel
        {
            get { return _container.Resolve<MainViewModel>(); }
        }

        public PerformanceViewModel PerformanceViewModel
        {
            get { return _container.Resolve<PerformanceViewModel>(); }
        }

        public TextCellViewModel TextCellViewModel
        {
            get { return _container.Resolve<TextCellViewModel>(); }
        }
    }
}
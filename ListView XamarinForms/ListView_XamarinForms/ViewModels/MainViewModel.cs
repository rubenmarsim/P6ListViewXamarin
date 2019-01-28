using ListView_XamarinForms.Services.Navigation;
using ListView_XamarinForms.ViewModels.Base;
using System.Windows.Input;

namespace ListView_XamarinForms.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ICommand _basicCommand;
        private ICommand _customCellCommand;
        private ICommand _dataBindCommand;
        private ICommand _imageCellCommand;
        private ICommand _performanceCommand;
        private ICommand _textCellCommand;

        private INavigationService _navigationService;

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ICommand BasicCommand
        {
            get { return _basicCommand = _basicCommand ?? new DelegateCommand(BasicCommandExecute); }
        }

        public ICommand CustomCellCommand
        {
            get { return _customCellCommand = _customCellCommand ?? new DelegateCommand(CustomCellCommandExecute); }
        }

        public ICommand DataBindCommand
        {
            get { return _dataBindCommand = _dataBindCommand ?? new DelegateCommand(DataBindCommandExecute); }
        }

        public ICommand ImageCellCommand
        {
            get { return _imageCellCommand = _imageCellCommand ?? new DelegateCommand(ImageCellCommandExecute); }
        }

        public ICommand PerformanceCommand
        {
            get { return _performanceCommand = _performanceCommand ?? new DelegateCommand(PerformanceCommandExecute); }
        }

        public ICommand TextCellCommand
        {
            get { return _textCellCommand = _textCellCommand ?? new DelegateCommand(TextCellCommandExecute); }
        }

        private void BasicCommandExecute()
        {
            _navigationService.NavigateTo<BasicViewModel>();
        }

        private void CustomCellCommandExecute()
        {
            _navigationService.NavigateTo<CustomCellViewModel>();
        }

        private void DataBindCommandExecute()
        {
            _navigationService.NavigateTo<DataBindingViewModel>();
        }

        private void ImageCellCommandExecute()
        {
            _navigationService.NavigateTo<ImageCellViewModel>();
        }

        private void PerformanceCommandExecute()
        {
            _navigationService.NavigateTo<PerformanceViewModel>();
        }

        private void TextCellCommandExecute()
        {
            _navigationService.NavigateTo<TextCellViewModel>();
        }
    }
}

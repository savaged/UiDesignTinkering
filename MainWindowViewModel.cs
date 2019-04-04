using GalaSoft.MvvmLight;
using System.Collections.Generic;

namespace UiDesignTinkering
{
    public class MainWindowViewModel : ViewModelBase
    {
        private MainViews _mainViewSelected;
        private readonly IDictionary<int, IMainViewModel> _mainViewModels;

        public MainWindowViewModel()
        {
            ServiceChargeStoreViewModel = new MainViewModel<ServiceChargeStore>();
            InsuranceStoreViewModel = new MainViewModel<InsuranceStore>();
            RentStoreViewModel = new MainViewModel<RentStore>();
            SchemeViewModel = new MainViewModel<Scheme>();
            ClientViewModel = new MainViewModel<Client>();
            NewsViewModel = new MainViewModel<News>();
            TaskViewModel = new MainViewModel<Task>();
            _mainViewModels = new Dictionary<int, IMainViewModel>
            {
                { (int)MainViews.ServiceCharge, ServiceChargeStoreViewModel },
                { (int)MainViews.Insurance, InsuranceStoreViewModel },
                { (int)MainViews.Rent, RentStoreViewModel },
                { (int)MainViews.Scheme, SchemeViewModel },
                { (int)MainViews.Client, ClientViewModel },
                { (int)MainViews.News, NewsViewModel },
                { (int)MainViews.Task, TaskViewModel }
            };
            MainViewSelected = MainViews.News;
        }

        public MainViews MainViewSelected
        {
            get => _mainViewSelected;
            set
            {
                Set(ref _mainViewSelected, value);
                SetFocusOnMainViewModels();
            }
        }

        public IMainViewModel ServiceChargeStoreViewModel { get; }

        public IMainViewModel InsuranceStoreViewModel { get; }

        public IMainViewModel RentStoreViewModel { get; }

        public IMainViewModel SchemeViewModel { get; }

        public IMainViewModel ClientViewModel { get; }

        public IMainViewModel NewsViewModel { get; }

        public IMainViewModel TaskViewModel { get; }

        private void SetFocusOnMainViewModels()
        {
            foreach (var key in _mainViewModels.Keys)
            {
                var isSelected = key == (int)MainViewSelected; 
                _mainViewModels[key].HasFocus = isSelected;
            }
        }
    }
}

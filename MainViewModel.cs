using GalaSoft.MvvmLight;

namespace UiDesignTinkering
{
    public class MainViewModel<T> : BaseViewModel, IMainViewModel
        where T : IModel
    {
        private bool _hasFocus;

        public bool HasFocus
        {
            get => _hasFocus;
            set => Set(ref _hasFocus, value);
        }
    }
}

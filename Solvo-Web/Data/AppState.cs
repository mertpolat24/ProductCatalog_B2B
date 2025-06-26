namespace Solvo_Web.Data
{
    public class AppState
    {
        private bool _isAdmin = true;
        public bool IsAdmin
        {
            get => _isAdmin;
            set
            {
                if (_isAdmin != value)
                {
                    _isAdmin = value;
                    NotifyStateChanged();
                }
            }
        }

        private bool _pageActive = true;
        public bool PageActive
        {
            get => _pageActive;
            set
            {
                if (_pageActive != value)
                {
                    _pageActive = value;
                    NotifyStateChanged();
                }
            }
        }

        private bool _layoutActive = true;
        public bool LayoutActive
        {
            get => _layoutActive;
            set
            {
                if (_layoutActive != value)
                {
                    _layoutActive = value;
                    NotifyStateChanged();
                }
            }
        }

        public event Action OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

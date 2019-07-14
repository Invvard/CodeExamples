using GalaSoft.MvvmLight;

namespace InvvardDev.Examples.PluginApp.MainApp.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private string _windowsTitle;

        public string WindowsTitle
        {
            get { return _windowsTitle;}
            set { Set(ref _windowsTitle, value); }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                WindowsTitle = "Design time title";
            }
            else
            {
                WindowsTitle = "Plugin test app";
            }
        }
    }
}
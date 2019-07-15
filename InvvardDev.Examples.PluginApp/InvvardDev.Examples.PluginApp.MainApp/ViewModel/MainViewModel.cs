using System.Collections.Generic;
using System.Linq;
using GalaSoft.MvvmLight;
using InvvardDev.Examples.PluginApp.MainApp.Tools;
using InvvardDev.Examples.PluginApp.Models;

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
        private IPluginLoader<IKeyboardModel> _pluginLoader;
        private object _keyboardView;
        private string _windowsTitle;
        private List<string> _keyboardModelNames;

        public string WindowsTitle
        {
            get => _windowsTitle;
            set => Set(ref _windowsTitle, value);
        }

        public object KeyboardView
        {
            get => _keyboardView;
            set => Set(ref _keyboardView, value);
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IPluginLoader<IKeyboardModel> pluginLoader)
        {
            _pluginLoader = pluginLoader;

            _keyboardModelNames = pluginLoader.Plugins.Select(p => p.ModelName).ToList();
            KeyboardView = _pluginLoader.Plugins.First().GetKeyboardView();

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
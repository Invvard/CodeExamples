/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:InvvardDev.Examples.PluginApp.MainApp"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using InvvardDev.Examples.PluginApp.MainApp.Tools;
using InvvardDev.Examples.PluginApp.Models;

namespace InvvardDev.Examples.PluginApp.MainApp.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (ViewModelBase.IsInDesignModeStatic)
            {
                SimpleIoc.Default.Register<IPluginLoader<IKeyboardModel>, DesignPluginLoader<IKeyboardModel>>();
            }
            else
            {
                SimpleIoc.Default.Register<IPluginLoader<IKeyboardModel>>(() => new PluginLoader<IKeyboardModel>("plugins") , true);
            }

            SimpleIoc.Default.Register<MainViewModel>();
        }

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
        
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}
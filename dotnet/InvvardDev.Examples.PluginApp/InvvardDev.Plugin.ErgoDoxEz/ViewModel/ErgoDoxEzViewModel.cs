using GalaSoft.MvvmLight;

namespace InvvardDev.Plugin.ErgoDoxEz.ViewModel
{
    public class ErgoDoxEzViewModel : ViewModelBase
    {
        private string _firstRadioButtonContent;
        private string _secondRadioButtonContent;

        public string FirstRadioButtonContent
        {
            get => _firstRadioButtonContent;
            set => Set(ref _firstRadioButtonContent, value);
        }

        public string SecondRadioButtonContent
        {
            get => _secondRadioButtonContent;
            set => Set(ref _secondRadioButtonContent, value);
        }

        public ErgoDoxEzViewModel()
        {
            FirstRadioButtonContent = "Radio button 1";
            SecondRadioButtonContent = "Radio button 2";
        }
    }
}
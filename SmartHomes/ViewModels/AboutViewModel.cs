using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace SmartHomes.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private bool _Status = false;

        public bool Status
        {
            get { return _Status; }
            set 
            { 
                _Status = value;
                OnPropertyChanged(nameof(Status));
                updateText();
            }
        }

        private String _msgAc = "(OFF)";

        public String MsgAc
        {
            get { return _msgAc; }
            set 
            {
                _msgAc = value;
                OnPropertyChanged(nameof(MsgAc));
            }
        }

        private void updateText() {

            if (this.Status == true)
            {
                this.MsgAc = "(ON)";
            }
            else 
            {
                this.MsgAc = "(OFF)";
            }
        }
        public AboutViewModel()
        {
            //Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}
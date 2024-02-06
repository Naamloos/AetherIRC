using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AetherIRC.ViewModels
{
    public class ChatViewModel : INotifyPropertyChanged
    {
        public List<string> Channels
        {
            get => channels;
            set
            {
                channels = value;
                OnPropertyChanged();
            }
        }

        private List<string> channels = new();

        public List<string> Messages
        {
            get => messages;
            set
            {
                messages = value;
                OnPropertyChanged();
            }
        }

        private List<string> messages = new();

        public ChatViewModel() 
        {
            channels.Add("#mcdevs");
            channels.Add("#reddit-sysadmin");

            messages.Add("naamloos: 1");
            messages.Add("naamloos: 2");
            messages.Add("naamloos: 3");
            messages.Add("naamloos: 4");
            messages.Add("naamloos: 5");
            messages.Add("naamloos: 6");
            messages.Add("naamloos: 7");
            messages.Add("naamloos: 8");
            messages.Add("naamloos: 9");
            messages.Add("naamloos: 10");
            messages.Reverse();
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

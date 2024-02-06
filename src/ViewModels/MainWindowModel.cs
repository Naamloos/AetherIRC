using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AetherIRC.ViewModels
{
    public class MainWindowModel : INotifyPropertyChanged
    {
        public List<string> Servers
        {
            get => servers;
            set
            {
                servers = value;
                OnPropertyChanged();
            }
        }

        private List<string> servers = new();

        public MainWindowModel()
        {
            Servers.Add("Libera");
            Servers.Add("FreeNode");
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

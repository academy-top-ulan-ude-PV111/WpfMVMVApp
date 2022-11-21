using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVMVApp
{
    internal class AppViewModel : INotifyPropertyChanged
    {
        private Phone phoneSelect;
        public ObservableCollection<Phone> Phones { set; get; }
        public Phone PhoneSelect
        {
            get => phoneSelect;
            set
            {
                phoneSelect = value;
                OnPropertyChanged(nameof(PhoneSelect));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChangedEventArgs args = new PropertyChangedEventArgs(propName);
            PropertyChanged?.Invoke(this, args);
        }

        public AppViewModel()
        {
            Phones = new ObservableCollection<Phone>
            {
                new Phone("iPhone 5", "Apple"),
                new Phone("Galaxy A", "Samsung"),
                new Phone("iPhone XR", "Apple"),
                new Phone("Galaxy B", "Samsung")
            };
        }
    }
}

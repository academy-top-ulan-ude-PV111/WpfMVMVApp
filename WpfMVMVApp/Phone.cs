using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVMVApp
{
    internal class Phone : INotifyPropertyChanged
    {
        private string? model;
        private string? company;

        public string? Model
        {
            get => model;
            set
            {
                model = value;
                OnPropertyChanged(nameof(Model));
            }
        }

        public string? Company
        {
            get => company;
            set
            {
                company = value;
                OnPropertyChanged(nameof(Company));
            }
        }
        public Phone(string? model, string? company)
        {
            Model = model;
            Company = company;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChangedEventArgs args = new PropertyChangedEventArgs(propName);
            PropertyChanged?.Invoke(this, args);
        }
    }
}

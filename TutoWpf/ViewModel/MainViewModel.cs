using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TutoWpf.Data;
using TutoWpf.Models;

namespace TutoWpf.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<Daily> Dailies { get; set; }

        public IDailyService _dailyService;


        private Daily _selectedDaily;
        public event PropertyChangedEventHandler PropertyChanged;
        public Daily SelectedDaily
        {
            get { return _selectedDaily; }
            set { _selectedDaily = value; OnPropertyChanged(); }
        }

        public MainViewModel(IDailyService dailyService)
        {
            Dailies = new ObservableCollection<Daily>();
            _dailyService = dailyService;

        }

        public void Load()
        {
            var dailies = _dailyService.GetAll();

            foreach (var daily in dailies)
            {
                Dailies.Add(daily);
            }
        }


        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

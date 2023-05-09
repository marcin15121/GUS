using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;
using GUS.Models;
using Newtonsoft.Json;

namespace GUS.ViewModels
{
    public class AreasViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Area> Areas { get; set; }

        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        public AreasViewModel()
        {
            Areas = new ObservableCollection<Area>();
        }

        public async Task LoadAreasAsync()
        {
            IsLoading = true;
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://api-dbw.stat.gov.pl/api/1.1.0/area/area-area");
            var jsonContent = await response.Content.ReadAsStringAsync();
            var areas = JsonConvert.DeserializeObject<Area[]>(jsonContent);
            Areas.Clear();
            foreach (var area in areas)
            {
                Areas.Add(area);
            }
            IsLoading = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

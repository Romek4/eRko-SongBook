using eRkoSongBook.Data;
using eRkoSongBook.Model;
using System.Collections.ObjectModel;

namespace eRkoSongBook.ViewModel
{
    class CarolsViewModel
    {
        public ObservableCollection<Song> Carols { get; set; }

        public CarolsViewModel()
        {
            Carols = CarolsData.Carols;
        }
    }
}

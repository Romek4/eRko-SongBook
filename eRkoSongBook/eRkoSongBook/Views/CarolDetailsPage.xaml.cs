using eRkoSongBook.Data;
using eRkoSongBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eRkoSongBook.Views
{
    [QueryProperty("CarolName", "name")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarolDetailsPage : ContentPage
    {
        public string CarolName
        {
            set
            {
                BindingContext = CarolsData.Carols.FirstOrDefault(x => x.SongName == Uri.UnescapeDataString(value));
            }
        }

        public CarolDetailsPage()
        {
            InitializeComponent();
        }
    }
}
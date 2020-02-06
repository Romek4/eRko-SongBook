
using eRkoSongBook.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eRkoSongBook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarolsOverviewPage : ContentPage
    {
        public CarolsOverviewPage()
        {
            InitializeComponent();
        }

        private async void OnCarolSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string carolName = (e.SelectedItem as Song).SongName;
            await Shell.Current.GoToAsync($"caroldetails?name={carolName}");
        }
    }
}
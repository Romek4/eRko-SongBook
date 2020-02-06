
using eRkoSongBook.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eRkoSongBook
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("caroldetails", typeof(CarolDetailsPage));
        }
    }
}
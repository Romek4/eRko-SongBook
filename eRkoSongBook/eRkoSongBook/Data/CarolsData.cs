using eRkoSongBook.Model;
using System.Collections.ObjectModel;

namespace eRkoSongBook.Data
{
    static class CarolsData
    {
        public static ObservableCollection<Song> Carols = new ObservableCollection<Song>()
        {
            new Song
            {
                SongName = "A vy milí pastuškovia, do Betlema poďte",
                SongText = "Ó, Ježišku malučičký, čo tak tvrdo ležíš, " +
                        "čo chlpatý kožuštek si pod bok nepoložíš," +
                        "aby zakrýval nožičku, aj zohrial Tvoje ručičky," +
                        "ó, Ježišku malý, Ježišku spanilý" +
                        "\nÓ, Ježišku malučičký, poď s nami na salaš," +
                        "zanechaj ten pustý chlievik, v ktorom tu prebývaš." +
                        "Zanechaj aj detské plienky, oblečiem ťa do halienky," +
                        "ó, Ježišku malý, Ježišku spanilý"
            },

            new Song()
            {
                SongName = "Ach Bože roztomilý",
                SongText = "Počúvajte novinu: už je narodený," +
                        "Mesiáš, náš Spasiteľ v jasliach uložený." +
                        "Jemu vďaku vzdávajme a klaňajme sa mu" +
                        "v tomto čase radostnom, vďaky vzdajme Pánu"
            },

            new Song()
            {
                SongName = "Aký je to svit",
                SongText = "Aký je to svit, čože to má byť v Betleme?" +
                        "Hore sa majme, hneď povstávajme zo zeme" +
                        "ňn2. Ej, ej, pastieri, aké to chýry, aký hlas?" +
                        "/:Či sa mi sníva, či anjel spieva, a zve nás?:/"
            }
        };
    }
}

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
                        "\nčo chlpatý kožuštek si pod bok nepoložíš," +
                        "\naby zakrýval nožičku, aj zohrial Tvoje ručičky," +
                        "\nó, Ježišku malý, Ježišku spanilý" +
                        "\n\nÓ, Ježišku malučičký, poď s nami na salaš," +
                        "\nzanechaj ten pustý chlievik, v ktorom tu prebývaš." +
                        "\nZanechaj aj detské plienky, oblečiem ťa do halienky," +
                        "\nó, Ježišku malý, Ježišku spanilý"
            },

            new Song()
            {
                SongName = "Ach Bože roztomilý",
                SongText = "Počúvajte novinu: už je narodený," +
                        "\nMesiáš, náš Spasiteľ v jasliach uložený." +
                        "\nJemu vďaku vzdávajme a klaňajme sa mu" +
                        "\nv tomto čase radostnom, vďaky vzdajme Pánu"
            },

            new Song()
            {
                SongName = "Aký je to svit",
                SongText = "Aký je to svit, čože to má byť v Betleme?" +
                        "\n/:Hore sa majme, hneď povstávajme zo zeme:/" +
                        "\n\nEj, ej, pastieri, aké to chýry, aký hlas?" +
                        "\n/:Či sa mi sníva, či anjel spieva, a zve nás?:/"
            }
        };
    }
}

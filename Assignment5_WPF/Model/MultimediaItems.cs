using System.Collections.ObjectModel;
using static Assignment5_WPF.Model.Multimedia;

namespace Assignment5_WPF.Model
{
    public class MultimediaItems : ObservableCollection<Multimedia>
    {
        public static ObservableCollection<Multimedia> MultimediaList { get; } = new ObservableCollection<Multimedia>();

        public MultimediaItems()
        {
            MultimediaList.Add(new Multimedia("Ten", "Pearl Jam", "Soft Rock", "1991", MediaType.CD));
            MultimediaList.Add(new Multimedia("Wall", "Pink Floyd", "Soft Rock", "1979", MediaType.CD));
            MultimediaList.Add(new Multimedia("Nevermind", "Nirvana", "Rock", "1991", MediaType.CD));
            MultimediaList.Add(new Multimedia("Back In Black", "Metallica", "Rock", "1980", MediaType.CD));
            MultimediaList.Add(new Multimedia("Purple Rain", "Prince", "Pop", "1984", MediaType.CD));
        }


    }
}
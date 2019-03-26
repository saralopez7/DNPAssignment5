using System.Collections.ObjectModel;
using static Assignment5.Model.Multimedia;

namespace Assignment5.Model
{
    /// <summary>
    /// The advantage of ObservableCollection over List is that it implements INotifyCollectionChanged.
    /// This interface raises an event whenever the collection is modified by insertion, removal, or replacement.
    /// </summary>
    public class MultimediaElements : ObservableCollection<Multimedia>
    {
        public static ObservableCollection<Multimedia> MultimediaList { get; } = new ObservableCollection<Multimedia>();
   
        public MultimediaElements()
        {
            MultimediaList.Add(new Multimedia("Imagine", "John Lennon", "Music", MediaType.CD));
            MultimediaList.Add(new Multimedia("One", "U2", "Music", MediaType.DVD));
            MultimediaList.Add(new Multimedia("Billie Jean", "Michael Jackson", "Music", MediaType.DVD));
            MultimediaList.Add(new Multimedia("Bohemian Rhapsody", "Queen", "Music", MediaType.CD));
            MultimediaList.Add(new Multimedia("Hey Jude", "The Beatles", "Music", MediaType.DVD));
        }


    }
}
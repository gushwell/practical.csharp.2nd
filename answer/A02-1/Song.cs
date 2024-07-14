namespace CSharp.Exercises;

public class Song {

    public string Title { get; private set; }
    public string ArtistName { get; private set; }
    public int Length { get; private set; }

    // 2.1.2
    public Song(string title, string artistname, int length) {
        Title = title;
        ArtistName = artistname;
        Length = length;
    }
}

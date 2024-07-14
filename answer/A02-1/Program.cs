using System.ComponentModel.DataAnnotations;

using CSharp.Exercises;

// 2.1.3
var songs = new Song[] {
                new Song("Let it be", "The Beatles", 243),
                new Song("Bridge Over Troubled Water", "Simon & Garfunkel", 293),
                new Song("Close To You", "Carpenters", 276),
                new Song("Honesty", "Billy Joel", 231),
                new Song("I Will Always Love You", "Whitney Houston", 273),
            };
PrintSongs(songs);

// 2.1.4
static void PrintSongs(Song[] songs) {
    foreach (var song in songs) {
        var minutes = song.Length / 60;
        var seconds = song.Length % 60;
        Console.WriteLine($"{song.Title}, {song.ArtistName} {minutes}:{seconds:00}");
    }
    Console.WriteLine();

    // 上記のように計算で求めても良いが、TimeSpanを利用することもできる。
    foreach (var song in songs) {
        var timespan = TimeSpan.FromSeconds(song.Length);
        Console.WriteLine($"{song.Title}, {song.ArtistName} {timespan.Minutes}:{timespan.Seconds:00}");
    }
    Console.WriteLine();

    // 以下のようにも書ける
    foreach (var song in songs) {
        Console.WriteLine(@"{0}, {1} {2:m\:ss}",
            song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));
    }
}

/*
   @"{0}, {1} {2:m\:ss}" について
   {} の中で、:は特別な意味を持っている。そのため、: を 文字':'として表示させるために
   \: としている。なお、\: をエスケープシーケンスと認識させないように、@を先頭に付加している。
*/

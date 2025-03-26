using System;

namespace modul6_103022300009
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                SayaTubeUser user = new SayaTubeUser("Muhammad Fathir Rizky Salam");

                for (int i = 1; i <= 8; i++)
                {
                    string videoTitle = $"Review Film Bagus untuk di tonton{i}";

                    SayaTubeVideo video = new SayaTubeVideo(videoTitle);

                    video.IncreasePlayCount(1000000 * i);

                    user.addVideo(video);
                }
                Console.WriteLine("Total play count:{user.GetTotalVideoPlayCount()}");

                user.PrintAllVideoPlayCount();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Terjadi Kesalahan: {e.Message}");
            }
        }
    }
}
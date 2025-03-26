using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300009
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Video title cannot be empty");
            }

            if (title.Length > 100)
            {
                throw new ArgumentException("Video title cannot be more than 100 characters");
            }

            Random random = new Random();
            this.id = random.Next(10000, 99999);  
            this.title = title;
            this.playCount = 0;

            Debug.Assert(this.playCount == 0, "Error Playcount harus 0 saat objek di buat!");
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 25000000)
            {
                throw new ArgumentOutOfRangeException("Invalid play count increment");
            }

            Debug.Assert(playCount + count >= playCount, "Error : terjadi overflow pada playCount!");

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                this.playCount = int.MaxValue;

            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID : {id}");
            Console.WriteLine($"Title: {title}" );
            Console.WriteLine("Play Count: {playCount}");
        }

        public int GetPlayCount() => playCount;
        public string GetTitle() =>  title;
    }
}

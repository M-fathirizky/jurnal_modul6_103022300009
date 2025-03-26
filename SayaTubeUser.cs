using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300009
{
    class SayaTubeUser
    {
        private int id;
        private string username;
        private List<SayaTubeVideo> uploadedVideos;

        public SayaTubeUser(string username)
        {
            if (string.IsNullOrEmpty(username) || username.Length > 100)
            {
                throw new ArgumentException("Username tidak boleh kosong dan tidak boleh lebih dari 100 karakter");
            }
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }
        public int GetTotalVideoPlayCount()
        {
            int totalPlayCount = 0;
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                totalPlayCount += video.GetPlayCount();
            }
            return totalPlayCount;
        }

        public void addVideo(SayaTubeVideo video)
        {
            if (video == null)
            {
                throw new ArgumentNullException("Video tidak boleh null");
            }

            if (uploadedVideos.Count >= 8)
            {
                throw new Exception("Video sudah mencapai batas maksimal");
            }
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: " + username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " Judul: " + uploadedVideos[i].GetTitle());
            }

        }
    }
}

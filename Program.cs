using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302200049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            a.PrintVideoDetails();
            a.IncreasePlayCount(1);
            a.PrintVideoDetails();
        }
    }
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string a)
        {
            Random b = new Random();
            Console.WriteLine("Five random integer values:");
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,15:N0}", b.Next());
            Console.WriteLine();
            this.title = a;
            playCount = 0;
            setPlayCount(123);
        }
        public void IncreasePlayCount(int a)
        {
            playCount += a;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("id :" + id);
            Console.WriteLine("Title :" + title);
            Console.WriteLine("PlayCount : " + playCount);
            Console.WriteLine();
        }
        public void setPlayCount(int a)
        {
            this.playCount = a;
        }
        public string getTitle()
        {
            return this.title;
        }
    }
}
using System;

namespace Zadatak_OOP_koncept
{
    internal class Program
    {
        public int GenerisiBroj()
        {
            Random randomBroj = new Random();
            return randomBroj.Next(101);
        }
        


        static void Main(string[] args)
        {
            Heroj heroj1 = new Carobnjak();
            Heroj heroj2 = new Macevalac();
            Cudoviste cudoviste1 = new Zmaj();
            Cudoviste cudoviste2 = new Pauk();
            
        }
    }
}

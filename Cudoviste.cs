using System;

namespace Zadatak_OOP_koncept
{
    public class Cudoviste 
    {
        public int Health;

        public int Rng() 
        {
            Random randomBroj = new Random();
            return randomBroj.Next(2);
        }
        public int IzborNapada(int napad1, int napad2) 
        {
            int br = Rng();
            if (br == 0)
            {
                return napad1;
            }
            else return napad2;
        }
    }
}

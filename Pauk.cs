namespace Zadatak_OOP_koncept
{
    public class Pauk:Cudoviste
    {
        public static int napadUdarac = 5;
        public static int napadUjed = 8;
        public Pauk() 
        {
            Health = 100;
            IzborNapada(napadUdarac, napadUjed);
        }
    }
}

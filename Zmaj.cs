namespace Zadatak_OOP_koncept
{
    public class Zmaj:Cudoviste
    {
        public static int napadUdarac = 5;
        public static int napadVatra = 20;
        public Zmaj() 
        {
            Health = 150;
            IzborNapada(napadUdarac, napadVatra);
        }
        
    }
}

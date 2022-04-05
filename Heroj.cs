using System;

namespace Zadatak_OOP_koncept
{
    public class Heroj 
    {
        public int Health;
        public object[] Ranac = new object[1];
        object aktivnoOruzije = null;

        public void UzmiOruzije(Oruzije oruzije)
        {
            if (Ranac[0] == null)
            {
                Ranac[0] = oruzije;
            }
            else if (Ranac[1] == null)
            {
                Ranac[1] = oruzije;
            }
            else throw new Exception("Ranac je pun!");
        }

        public void BaciOruzije(int baci)
        {
            if (baci == 0)
            {
                Ranac[0] = null;
            }
            else if(baci == 1) 
            {
                Ranac[1] = null;
            }
            else throw new Exception("Ranac je prazan");
        }

        public void IzaberiOruzije(int izbor) 
        {
            if (izbor == 0)
            {
                aktivnoOruzije = Ranac[0];
            }
            else if (izbor == 1)
            {
                aktivnoOruzije = Ranac[1];
            }
            else throw new Exception("Mesto u rancu je prazno");
        }
    }
}

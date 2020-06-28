using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatek
{
    class JatekTer
    {
        const int MAX_ELEMSZAM = 1000; //maximális elemszám
        private int elemN = 0; // éppen hány elemet tárolunk
        JatekElem[] elemek = new JatekElem[MAX_ELEMSZAM];
        private int meretX, meretY;
        public int MeretX { get { return meretX; } set { meretX = value; } }
        public int MeretY { get { return meretY; } set { meretX = value; } }

        public JatekTer(int meretX, int meretY)
        {
            this.meretX = meretX;
            this.meretY = meretY;
        }

        public void Felvetel(JatekElem ujElem)
        {
            elemek[elemN] = ujElem;
            elemN++;
        }

        public void Torles(JatekElem torlendoElem)
        {
            int i = 0;
            while (i < elemN && elemek[i] != torlendoElem)
            {
                i++;
            }
            if (i < elemN)
            {
                elemek[i] = elemek[elemN-1];                
                elemek[elemN-1] = null;
            }
            elemN--;
        }
        public JatekElem[] MegadottHelyenLevok(int x, int y, int r = 0)
        {
            List<JatekElem> elemList = new List<JatekElem>();
            for (int i = 0; i < elemN; i++)
            {
                if (Math.Abs(elemek[i].X - x) <= r &&
                    Math.Abs(elemek[i].Y - y) <= r)
                {
                    elemList.Add(elemek[i]);
                }
            }
            return elemList.ToArray();
        }        
    }
}

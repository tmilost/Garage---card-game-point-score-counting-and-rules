using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaza
{
    class KanastaCaculatePoints
    {
        private int brojBodova;
        private int predhodniRezultat;
        private int rezultat;

        public KanastaCaculatePoints()
        {

        }
        public int BrojBodova { get => brojBodova; set => brojBodova = value; }
        public int Rezultat { get => rezultat; set => rezultat = value; }
        public int PredhodniRezultat { get => predhodniRezultat; set => predhodniRezultat = value; }

        public int AllNumberOfPoints()
        {

            int i=0;
            i++;
            int[] niz = new int[99];
            niz[i] = brojBodova;
            return niz[i]; 
        }

        public int ukupanBrojBodova()
        {
            rezultat = predhodniRezultat+brojBodova;
            return rezultat;
        }
        
        public int zaOtvaranje()
        {
            int b;
            if (rezultat < 0)
            {
                b = 15;
                return b;
            }
            else if (rezultat < 1500)
            {
                b = 50;
            }
            else if (rezultat >= 1500 && rezultat < 3000)
            {
                b = 90;
            }
            else if(rezultat >= 3000)
            {
                b = 120;
            }
            else
            {
                b = 999999;
            }
            return b;
        }
    }
}

using System;

namespace SavasOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            DusmanTank dusmanTank = new DusmanTank();
            
            dusmanTank.Hizlan();
            dusmanTank.DusmanAdi();
            dusmanTank.SilahKullan();


            DusmanRobotu dusmanRobotu = new DusmanRobotu();
            DusmanAdapter sena = new DusmanAdapter(dusmanRobotu);
            sena.SilahKullan();
            sena.Hizlan();
            sena.DusmanAdi();


        }
    }
}

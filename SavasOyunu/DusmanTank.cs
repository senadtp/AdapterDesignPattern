using System;
using System.Collections.Generic;
using System.Text;

namespace SavasOyunu
{
    public class DusmanTank : IDusman
    {
       

        public void Hizlan()
        {
            Console.WriteLine("Tank Hızlanısı");
        }

        public void DusmanAdi()
        {
            Console.WriteLine("Ben Bir Tankım");
        }

        public void SilahKullan()
        {
            Console.WriteLine("Tank Sılahı");
        }
    }
}

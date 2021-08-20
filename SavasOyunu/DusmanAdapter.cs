using System;
using System.Collections.Generic;
using System.Text;

namespace SavasOyunu
{
    public class DusmanAdapter : IDusman
    {
        DusmanRobotu dusmanRobotu;
        public DusmanAdapter(DusmanRobotu robotu)
        {
            this.dusmanRobotu = robotu;
        }

        public void Hizlan()
        {
            dusmanRobotu.Yuru();
        }

        public void DusmanAdi()
        {
            dusmanRobotu.RobotIsmi();
        }

        public void SilahKullan()
        {
            dusmanRobotu.YumrukAt();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SavasOyunu
{
    public class DusmanRobotu : IDusmanYeni
    {
        public void RobotIsmi()
        {
            Console.WriteLine("Ben Bir Robotum");
        }

        public void YumrukAt()
        {
            Console.WriteLine("Robot Yumruğu");
        }

        public void Yuru()
        {
            Console.WriteLine("Robot Yuruyusu");
        }
    }
}

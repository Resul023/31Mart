using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Bycle : Vehicle
    {
        public Bycle(int millage)
        {
            this.Millage = millage;
        }
        public void Drive(int Way)
        {

                this.Millage += Way;

        }
    }
}

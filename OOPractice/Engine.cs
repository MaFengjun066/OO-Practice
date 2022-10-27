using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class Engine
    {
        public float speed;
        private string type;

        public Engine(string type)
        {
            this.type = type;
            if (type.Equals("GasolineEngine"))
            {
                speed = 30;
            }
            else if (type.Equals("ElecticEngine"))
            {
                speed = 25;
            }
        }
    }
}

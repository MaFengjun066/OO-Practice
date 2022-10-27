using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class ElecticEngine : IEngine
    {
        public int speed;
        private string type;

        public ElecticEngine()
        {
            this.type = "ElecticEngine";
            this.speed = 25;
        }

        public int Speed { get => speed; set => speed = value; }
    }
}

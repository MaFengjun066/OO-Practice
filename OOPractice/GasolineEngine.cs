using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class GasolineEngine : IEngine
    {
        public int speed;
        private string type;

        public GasolineEngine()
        {
            this.type = "GasolineEngine";
            this.speed = 30;
        }

        public int Speed { get => speed; set => speed = value; }
    }
}

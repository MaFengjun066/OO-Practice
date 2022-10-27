namespace OOPractice
{
    using System;
    public class Car : Vehicle
    {
        public Car(string name, Engine engine)
        {
            this.name = name;
            this.speed = engine.speed;
        }
    }
}

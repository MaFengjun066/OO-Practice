namespace OOPractice
{
    using System;
    public class Car : Vehicle
    {
        public Car(string name, IEngine engine)
        {
            this.name = name;
            this.speed = engine.Speed;
        }
    }
}

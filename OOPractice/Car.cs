namespace OOPractice
{
    using System;
    public class Car
    {
        private string name;
        private float speed;

        public Car(string name, float speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string SpeedUp()
        {
            return $"{name}: speed up {speed} km/h";
        }
    }
}

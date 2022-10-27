namespace OOPractice
{
    public class Vehicle
    {
        private string name;
        private float speed;

        public Vehicle(string name, float speed)
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
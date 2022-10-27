namespace OOPractice
{
    public class Vehicle
    {
        protected string name;
        protected float speed;

        public string SpeedUp()
        {
            return $"{name}: speed up {speed} km/h";
        }
    }
}
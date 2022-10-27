namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class Test
    {
        [Fact]
        public void Should_return_message_when_speed_up_given_car_name()
        {
            //given
            Car car = new Car("Cool Car", 30);
            //when
            string message = car.SpeedUp();
            //then
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }

        [Fact]
        public void Should_return_message_when_speed_up_given_truck_name()
        {
            //given
            Truck truck = new Truck("Big Truck", 10);
            //when
            string message = truck.SpeedUp();
            //then
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }
    }
}

namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class Test
    {
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

        [Fact]
        public void Should_return_message_when_driver_drive_truck()
        {
            //given
            Driver driver = new Driver(new Truck("Big Truck", 10));
            //when
            string message = driver.Drive();
            //then
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }

        [Fact]
        public void Should_return_message_30_when_driver_drive_car_with_gas()
        {
            //given
            Driver driver = new Driver(new Car("Cool Car", new GasolineEngine()));
            //when
            string message = driver.Drive();
            //then
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }

        public void Should_return_message_25_when_driver_drive_car_with_electric()
        {
            //given
            Driver driver = new Driver(new Car("Cool Car", new ElecticEngine()));
            //when
            string message = driver.Drive();
            //then
            Assert.Equal("Cool Car: speed up 25 km/h", message);
        }
    }
}

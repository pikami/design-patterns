namespace TE.Uzd5431
{
    public abstract class Builder
    {
        public Car car;

        public Builder()
        {
            car = new Car();
        }

        public Car BuildCar()
        {
            return car;
        }

        public abstract CarConfigurator AddEngine(string engine);
        public abstract CarConfigurator AddWheels(string wheels);
        public abstract CarConfigurator AddBody(string body);
        public abstract CarConfigurator AddSeats(int seats);
    }
}

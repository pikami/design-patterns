namespace TE.Uzd5431
{
    public class CarConfigurator : Builder
    {
        public override CarConfigurator AddEngine(string engine)
        {
            car.Engine = engine;
            return this;
        }

        public override CarConfigurator AddWheels(string wheels)
        {
            car.Wheels = wheels;
            return this;
        }

        public override CarConfigurator AddBody(string body)
        {
            car.Body = body;
            return this;
        }

        public override CarConfigurator AddSeats(int seats)
        {
            car.Seats = seats;
            return this;
        }
    }
}

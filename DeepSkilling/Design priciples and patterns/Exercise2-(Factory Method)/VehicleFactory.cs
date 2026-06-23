class VehicleFactory
{
    public static IVehicle GetVehicle(string type)
    {
        if (type == "Car")
            return new Car();

        if (type == "Bike")
            return new Bike();

        return null;
    }
}
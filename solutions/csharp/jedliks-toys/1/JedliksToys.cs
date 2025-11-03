// var car = RemoteControlCar.Buy();
// for (int i = 0; i < 100; i++)
// {
//     Console.WriteLine(car.BatteryDisplay());
//     Console.WriteLine(car.DistanceDisplay());
//     car.Drive();
// }

class RemoteControlCar
{
    private int _metersDriven = 0;
    private int _battery = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_metersDriven} meters";
    }

    public string BatteryDisplay()
    {
        return _battery == 0 ? "Battery empty" : $"Battery at {_battery}%";
    }

    public void Drive()
    {
        if (_battery <= 0) return;
        _metersDriven += 20;
        _battery -= 1;
    }
}

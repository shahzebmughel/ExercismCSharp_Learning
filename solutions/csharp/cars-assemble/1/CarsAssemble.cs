static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        // 77%
        if (speed == 10)
        {
            return 0.77;
        }
        
        
        // 80%
        if (speed == 9)
        {
            return 0.80;
        }
        
        // 90%
        if (speed >= 5 && speed <= 8)
        {
            return 0.90;
        }
        
        // 100%
        if (speed >= 1 && speed <= 4)
        {
            return 1.0;
        }
        
        // 0 %
        return 0.0;
        
    }
    
    
    //the car rate per hour is 221 so if we have the speed of 5, we have 5 * 221 cars per 5 hours.
    // excluding the success rate so we need to include it. so for 5 we would get 994.5
    public static double ProductionRatePerHour(int speed)
    {
        return speed * 221 * SuccessRate(speed);
    }

    /*
     *  the care rate per hour is 221 and for example we want 6minutes.
     * so it would be 6 * 221 / 60 minutes and the success rate (90%). so it should be 19 in int
     */
    public static int WorkingItemsPerMinute(int speed)
    {
        int toMinutes = speed * 221 / 60;
        
        return Convert.ToInt32(toMinutes * SuccessRate(speed));
    }
}

//
// for (int i = 0; i < BirdCount.LastWeek().Length; i++)
// {
//     System.Console.Write(BirdCount.LastWeek()[i]);
// }
//
// Console.WriteLine();
//
// BirdCount birds = new BirdCount(new int[] { 2, 5, 0, 7, 4, 1});
//
// Console.WriteLine(birds.Today());
// Console.WriteLine(birds.HasDayWithoutBirds());
// Console.WriteLine(birds.CountForFirstDays(6));
// Console.WriteLine(birds.BusyDays());

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (var bird in birdsPerDay)
        {
            if (bird == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        // return 0 if given Value is higher than the Arrays given allowed Length
        if (numberOfDays > birdsPerDay.Length)
        {
            return 0;
        }
        
        int countDays = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            countDays += birdsPerDay[i];    
        }

        return countDays;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (var bird in birdsPerDay)
        {
            if (bird >= 5)
            {
                busyDays++;
            }
        }
        return busyDays;
    }
}

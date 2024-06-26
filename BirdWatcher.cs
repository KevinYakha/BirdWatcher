using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return [0, 2, 5, 3, 7, 8, 4];
    }

    public int Today()
    {
        return birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int birdCount in birdsPerDay)
        {
            if (birdCount == 0)
                return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            sum += birdsPerDay[i];
        }
        return sum;
    }

    public int BusyDays()
    {
        int busyDaysCount = 0;
        foreach (int birdCount in birdsPerDay)
        {
            busyDaysCount += birdCount >= 5 ? 1 : 0;
        }
        return busyDaysCount;
    }
}

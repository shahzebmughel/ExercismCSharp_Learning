static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        Console.WriteLine("Ran Method SCHEDULE");
       return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        // Method should return true if the appointment date and time has already passed, and false if it is in the future or in the Present Time.

        if (appointmentDate < DateTime.Now)
        {
            return true;

        }
        else
        {
            return false;
        }
       
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        // Method should return true if the appointment is in the afternoon (between 12:00 and 18:00), and false otherwise.
        if (appointmentDate.Hour >= 12 && appointmentDate.Hour < 18)
        {
            return true;
        }
        return false;
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate:M/d/yyyy} {appointmentDate:h:mm:ss tt}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15);
    }
}

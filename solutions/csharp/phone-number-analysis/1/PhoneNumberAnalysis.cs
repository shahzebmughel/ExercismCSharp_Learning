public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var localNumber = phoneNumber.Split('-').ToArray();
        var areaCode = localNumber[0];
        var prefixCode = localNumber[1];

        var resultIsFake = false;
        if (prefixCode == "555")
        {
            resultIsFake = true;
        }
        else
        {
            resultIsFake = false;
        }

        var resultIsNewYork = false;
        if (areaCode == "212" || areaCode == "646" || areaCode == "332" || areaCode == "917")
        {
            resultIsNewYork = true;
        }
        else
        {
            resultIsNewYork = false;
        }

            //Console.WriteLine("PhoneNumber:" + phoneNumber);
            return (resultIsNewYork, resultIsFake, localNumber[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
         return phoneNumberInfo.IsFake;
    }
}

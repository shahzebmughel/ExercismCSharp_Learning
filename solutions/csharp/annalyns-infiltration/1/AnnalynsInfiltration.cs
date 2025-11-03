static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake)
        {
            return false;
        }
        else
        {
            return true;
        }
        
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
    }

    public static bool CanSpy(bool knwsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knwsAwake || archerIsAwake || prisonerIsAwake)
        {
            return true;
        }
        else
        {
            return false;
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (!archerIsAwake && prisonerIsAwake )
        {
            return true;
        }
        else
        {
            return false;
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        // if pet present | archer asleep | prisoner awake
        // or
        /* if dog not present prisoner and her msut be very sneaky.
            if dog not present, prisoner must be awake and knight && arhcher must be sleeping for it to work
        */

        if (petDogIsPresent && !archerIsAwake )
        {
            return true;
        }
        if ((!petDogIsPresent && prisonerIsAwake) && !knightIsAwake && !archerIsAwake )
        {
            return true;
        }
        else
        {
            return false;
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
    }
}
